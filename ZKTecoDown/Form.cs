using Quartz;
using System.Data.OleDb;
using System.Diagnostics;

namespace ZKTecoDown
{

    public partial class MachineDL : Form
    {
        private NotifyIcon trayIcon = new();
        private ContextMenuStrip contextMenu = new();
        private ToolStripMenuItem exitMenuItem = new("Salir");
        private IJobDetail? job;
        private ITrigger? trigger;
        private IScheduler? scheduler;
        private List<Tuple<string, string, int>> IPList = new();
        private MachineConnection MachConn = new();
        private int CurrentConnectedIndex = -1;
        public MachineDL()
        {

            InitializeComponent();

            Debug.WriteLine("Starting app...");

            Icon = new Icon(@"./icon.ico");

            exitMenuItem.Click += new EventHandler(Exit);

            contextMenu.Items.Add(exitMenuItem);

            trayIcon.Text = "Descargador de relojes";
            trayIcon.ContextMenuStrip = contextMenu;
            trayIcon.DoubleClick += new EventHandler(DoubleClickTrayIcon);
            trayIcon.Icon = Icon;
            trayIcon.Visible = true;

            Config.Initialize(@"./conf.ini");
            Text += " (" + Config.initconf.Company + ")";
            Companyname.Text = Config.initconf.Company;
            MachineQuant.Text = Config.initconf.MachineQuant.ToString();
            DBDirectory.Text = Config.initconf.DatabasePath;
            LogsDirectory.Text = Config.initconf.LogsPath;
            TimePicker.Value = new DateTime(2000, 01, 01, Config.initconf.DLTime[0], Config.initconf.DLTime[1], 0);

            GetIpList();

            BuildScheduleJob();

            HideManagmentOptions();
        }
        
        #region Initialization
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

                    if (DataRow.Item3 <= 0 || DataRow.Item3 > 65535)
                        continue;

                    IPList.Add(DataRow);
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
        #endregion

        #region TrayIcon Events
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

        #endregion

        #region Connection Events
        private void ConnectButton_Click(object sender, EventArgs e)
        {

#if (DEBUG)
            ShowManagmentOptions();
#endif

            if (MachineComboBox.SelectedIndex == -1)
                return;

            if (MachConn.isConnected())
            {
                ConnectButton.Text = "Conectar";
                ConnectButton.BackColor = Color.Salmon;
                DLLogsthisMachine.Text = "Descargar registros del reloj ";
                HideManagmentOptions();
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
            else
            {
                ConnectButton.Text = "Desconectar";
                ConnectButton.BackColor = Color.LightGreen;
                DLLogsthisMachine.Text += MachineComboBox.SelectedText;
                ShowManagmentOptions();
                CurrentConnectedIndex = MachineComboBox.SelectedIndex;
            }

        }

        private void HideManagmentOptions()
        {
            MDLTabControl.TabPages.Remove(MUserMangTab);
            MDLTabControl.TabPages.Remove(MLogsMangTab);
        }

        private void ShowManagmentOptions()
        {
            if (!MDLTabControl.TabPages.Contains(MUserMangTab))
                MDLTabControl.TabPages.Add(MUserMangTab);
       
            if (!MDLTabControl.TabPages.Contains(MLogsMangTab))
                MDLTabControl.TabPages.Add(MLogsMangTab);
        }

        #endregion

        #region Logs Management Events

        private void DownloadLogsFromAllMachines()
        {
            throw new NotImplementedException();
        }

        private async void SaveLogs()
        {
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                Config.initconf.DatabasePath + "Descargas.mdb";
            // Fichadas Alias dd-mm-yyyy_hh:mm:ss
            string LogFilePath = Config.initconf.LogsPath + $"Fichadas {MachConn.MachineAlias} {DateTime.Now:dd-MM-yyyy_HHmmss}.rei";

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
                            inoutType = "1";
                            break;
                        case 3:
                            inoutType = "2";
                            break;
                        case 4:
                            inoutType = "3";
                            break;
                        case 5:
                            inoutType = "4";
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

        private void DLLogsAllMachines_Click(object sender, EventArgs e)
        {

        }

        private async void DLLogsthisMachine_Click(object sender, EventArgs e)
        {
            if (!MachConn.isConnected())
                return;
            var eraseAfter = isClearAllLogs.Checked;
            await Task.Run(() => MachConn.DownloadAttendance(eraseAfter));
            UsersListBox.DataSource = MachConn.attendanceRecords;
            await Task.Run(() => SaveLogs());
        }

        #endregion

        #region User Management Events

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (MachConn.userInfo.Count < 1)
                return;

            var users2delete = UsersListBox.SelectedItems;

            foreach (var user in users2delete)
            {
                throw new NotImplementedException();
            }
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            NewUser PopUp = new();
            this.AddOwnedForm(PopUp);
            DialogResult dialogresult = PopUp.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {

            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
            PopUp.Dispose();
        }
        
        private async void DLUsers_Click(object sender, EventArgs e)
        {
            if (!MachConn.isConnected())
                return;

            await Task.Run(() => MachConn.DownloadUsers());
            UsersListBox.DataSource = MachConn.userInfo;
        }

        #endregion

        #region Config Events

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

        #endregion

        #region Job Class
        public class DownloadJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            JobDataMap datamap = context.MergedJobDataMap;
            MachineDL myMDL = (MachineDL)datamap["MachineDL"];
            await Task.Run(new Action(myMDL.DownloadLogsFromAllMachines));
            
        }
    }

        #endregion

    }

}