using Quartz;
using System.Data.OleDb;
using System.Diagnostics;

namespace ZKTecoDown
{

    public partial class MachineDL : System.Windows.Forms.Form
    {
        private NotifyIcon trayIcon;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem exitMenuItem;
        private IJobDetail job;
        private ITrigger trigger;
        private IScheduler scheduler;
        private List<Tuple<string, string, int>> IPList;
        private MachineConnection MachConn;
        private int CurrentConnectedIndex;
        public MachineDL()
        {

            InitializeComponent();

            Debug.WriteLine("Starting app...");

            MachConn = new MachineConnection();
            IPList = new List<Tuple<string, string, int>>();
            CurrentConnectedIndex = -1;
            Icon = new Icon(@"./icon.ico");
            trayIcon = new NotifyIcon();
            contextMenu = new ContextMenuStrip();
            exitMenuItem = new ToolStripMenuItem
            {
                Text = "Salir"
            };
            exitMenuItem.Click += new EventHandler(Exit);

            contextMenu.Items.Add(exitMenuItem);

            trayIcon.Text = "Descargador de relojes";
            trayIcon.ContextMenuStrip = contextMenu;
            trayIcon.DoubleClick += new EventHandler(DoubleClickTrayIcon);
            trayIcon.Icon = Icon;
            trayIcon.Visible = true;

            Config.Initialize(@"./conf.ini");
            Text += " (" + Config.initconf.Company + ")";
            CompanyName.Text = Config.initconf.Company;
            MachineQuant.Text = Config.initconf.MachineQuant.ToString();
            DBDirectory.Text = Config.initconf.DatabasePath;
            LogsDirectory.Text = Config.initconf.LogsPath;
            TimePicker.Value = new DateTime(2000, 01, 01, Config.initconf.DLTime[0], Config.initconf.DLTime[1], 0);

            GetIpList();

            BuildScheduleJob();
        }

        private void GetIpList()
        {
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                Config.initconf.DatabasePath + "Descargas.mdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand("SELECT Ip, Puerto, Ubicacion FROM Nodos", connection);
                connection.Open();

                OleDbDataReader DBreader = command.ExecuteReader(); 
                
                for (int i = 0; i < Config.initconf.MachineQuant && DBreader.Read(); i++)
                {
                    var DataRow = new Tuple<string, string, int>(DBreader.GetString(2),
                            DBreader.GetString(0), DBreader.GetInt32(1));
                    IPList.Append(DataRow);
                    MachineComboBox.Items.Add(DBreader.GetString(2));
                }
                DBreader.Close();
                connection.Close();
                DBreader.DisposeAsync();
                connection.DisposeAsync();

            }
        }

        private async void BuildScheduleJob()
        {
            // construct a scheduler factory using defaults

            // get a scheduler
            var schedulerFact = new Quartz.Impl.StdSchedulerFactory();
            scheduler = await schedulerFact.GetScheduler();
            await scheduler.Start();

            job = JobBuilder.Create<DownloadJob>()
                .WithIdentity("DownloadJob", "group1") // name "myJob", group "group1"
                .Build();
            job.JobDataMap.Put("MachineDL", this);

            trigger = TriggerBuilder.Create()
                .WithIdentity("trigger", "group1")
                .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(Config.initconf.DLTime[0], Config.initconf.DLTime[1]))
                .Build();

            await scheduler.ScheduleJob(job, trigger);
        }

        private void Exit(object? Sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Close();
        }

        private void DoubleClickTrayIcon(object? Sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
            }

            Activate();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void MachineDL_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            if (trayIcon.Visible)
                e.Cancel = true;
            else
            {
                trayIcon.Dispose();
                scheduler.Shutdown();
            }

        }

        public void DownloadAllMachines()
        {
            throw new NotImplementedException();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (MachConn.userInfo.Count < 1)
                return;

            var users2delete = UsersListBox.SelectedItems;

            foreach (var user in users2delete)
            {
                throw new NotImplementedException();
            }
        }

        private async void SetTimeButton_Click(object sender, EventArgs e)
        {
            var time = TimePicker.Value;
            var hour = time.Hour;
            var minute = time.Minute;

            // obtain a builder that would produce the trigger
            TriggerBuilder tb = trigger.GetTriggerBuilder();
            // update the schedule associated with the builder, and build the new trigger
            var newTrigger = tb.WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(hour, minute))
                .Build();

            await scheduler.RescheduleJob(trigger.Key, newTrigger);
            trigger = newTrigger;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (MachineComboBox.SelectedIndex == -1)
                return;

            if (MachConn.isConnected())
            {
                ConnectButton.Text = "Conectar";
                ConnectionCheckBox.Checked = false;
                MachConn.Disconnect();
                return;
            }

            var selectedMachine = IPList[MachineComboBox.SelectedIndex];
            if (!MachConn.Connect(selectedMachine.Item1, selectedMachine.Item2, selectedMachine.Item3))
            {
                Debug.WriteLine("Error connecting to device");
                MessageBox.Show("Error al conectar. Verificar que el dispositivo se encuentre conectado a la red.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            CurrentConnectedIndex = MachineComboBox.SelectedIndex;
            ConnectButton.Text = "Desconectar";
            ConnectionCheckBox.Checked = true;
        }

        private async void DLUsers_Click(object sender, EventArgs e)
        {
            if (!MachConn.isConnected())
                return;

            await Task.Run(() => MachConn.DownloadUsers());
            UsersListBox.DataSource = MachConn.userInfo;
        }

        private async void DLthisMachine_Click(object sender, EventArgs e)
        {
            if (!MachConn.isConnected())
                return;
            var eraseAfter = isClearAllLogs.Checked;
            await Task.Run(() => MachConn.DownloadAttendance(eraseAfter));
            UsersListBox.DataSource = MachConn.attendanceRecords;
            await Task.Run(() => SaveLogs());
        }

        private async void SaveLogs()
        {
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                Config.initconf.DatabasePath + "Descargas.mdb";
            // Fichadas Alias dd-mm-yyyy_hh:mm:ss
            string LogFilePath = Config.initconf.LogsPath + $"Fichadas {MachConn.MachineAlias} {DateTime.Now:dd-MM-yyyy_HH:mm:ss}";

            using (StreamWriter LogsFile = File.CreateText(LogFilePath))
            using (OleDbConnection connection = new(connectionString))
            {
                OleDbCommand command = new("", connection);
                var today = DateTime.Now;
                connection.Open();

                foreach (var Log in MachConn.attendanceRecords)
                {
                    var LogDateTime = new DateTime(Log.Year, Log.Month, Log.Day, Log.Hour, Log.Minute, Log.Second);
                    string inoutType;
                    switch (Log.InOut)
                    {
                        case 0:
                            inoutType = "E";
                            break;
                        case 1:
                            inoutType = "S";
                            break;
                        case 2:
                            inoutType = "SR";
                            break;
                        case 3:
                            inoutType = "ER";
                            break;
                        case 4:
                            inoutType = "OTE";
                            break;
                        case 5:
                            inoutType = "OTS";
                            break;
                        default:
                            inoutType = "E";
                            break;
                    }

                    command.CommandText = $"INSERT INTO Registros(Codigo, Fecha, Hora, Tipo, Nodo, FechaDescarga, HoraDescarga)" +
                    $" VALUES('{Log.ID}', '{LogDateTime.Date}', '{LogDateTime.TimeOfDay}', '{inoutType}', " +
                    $"'{MachineComboBox.Items[CurrentConnectedIndex]}', '{today.Date}', '{today.TimeOfDay}')";

                    command.ExecuteNonQuery();

                    LogsFile.WriteLine("{} {} {} {}   {}", Log.ID.PadLeft(8, '0'), LogDateTime.Date,
                        LogDateTime.TimeOfDay, inoutType, (CurrentConnectedIndex + 1).ToString().PadLeft(3, '0'));
                }
                LogsFile.Close();
                connection.Close();
                await connection.DisposeAsync();

            }
        }
    }

    public class DownloadJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            JobDataMap datamap = context.MergedJobDataMap;
            MachineDL myMDL = (MachineDL)datamap["MachineDL"];
            await Task.Run(new Action(myMDL.DownloadAllMachines));
            
        }
    }
}