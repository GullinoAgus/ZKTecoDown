using System.Data.OleDb;

namespace ZKTecoDown
{

    public partial class MachineDL : Form
    {
        private static log4net.ILog? log;
        private List<Tuple<string, string, int>> IPList = new();
        private MachineConnection MachConn = new();
        private int CurrentConnectedIndex = -1;
        public MachineDL()
        {
            
            InitializeComponent();
            
            if (!Config.Initialize(@"./conf.ini"))
            {
                Close();
                return;
            }

            Text += " (" + Config.initconf.Company + ")";
            Companyname.Text = Config.initconf.Company;
            MachineQuant.Text = Config.initconf.MachineQuant.ToString();
            DBDirectory.Text = Config.initconf.DatabasePath;
            LogsDirectory.Text = Config.initconf.LogsPath;

            log4net.GlobalContext.Properties["logsPath"] = Config.initconf.LogsPath;
            log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger("ZKDownloader");

            log.Info("Iniciando aplicacion...");
            if (!File.Exists(Config.initconf.DatabasePath + "Descargas.mdb"))
            {
                try
                {
                    if (!CreateDB())
                    {
                        throw new FileLoadException();
                    }
                    log.Info("Base de datos creada con exito.");
                }
                catch (Exception e)
                {
                    log.Error($"Error al crear la base de datos.\n" +
                    $"Contacte con un tecnico.\n" +
                    e.ToString());
                    MessageBox.Show($"Error al crear la base de datos.\n" +
                    $"Contacte con un tecnico.\n" +
                    e.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    Close();
                    return;
                }
            }

            GetIpList();

            HideManagmentOptions();
        }

        #region Initialization
        private void GetIpList()
        {
            var connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                Config.initconf.DatabasePath + "Descargas.mdb; Jet OLEDB:Database Password=u9120bkb;";

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

        private bool CreateDB()
        {
            var connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                Config.initconf.DatabasePath + "Descargas.mdb; Jet OLEDB:Database Password=u9120bkb;";

            var nodesTable = new ADOX.Table();
            var LogsTable = new ADOX.Table();
            nodesTable.Name = "Nodos";
            nodesTable.Columns.Append("IP");
            nodesTable.Columns.Append("Puerto", ADOX.DataTypeEnum.adInteger);
            nodesTable.Columns.Append("Ubicacion");
            LogsTable.Name = "Registros";
            LogsTable.Columns.Append("Codigo");
            LogsTable.Columns.Append("Fecha");
            LogsTable.Columns.Append("Hora");
            LogsTable.Columns.Append("Tipo");
            LogsTable.Columns.Append("Nodo");
            LogsTable.Columns.Append("FechaDescarga");
            LogsTable.Columns.Append("HoraDescarga");

            var PopUp = new AddMachine();
            var result = PopUp.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
            else
            {
                PopUp.Dispose();
                return false;
            }

            var cat = new ADOX.Catalog();
            cat.Create(connectionString);
            cat.Tables.Append(LogsTable);
            cat.Tables.Append(nodesTable);

            ADODB.Connection con = cat.ActiveConnection as ADODB.Connection;

            foreach (ListViewItem item in PopUp.IPAddressListview.Items)
            {
                object output;
                string commandText = $"INSERT INTO Nodos(IP, Puerto, Ubicacion) Values(" +
                    $"'{item.SubItems[1].Text}', '{item.SubItems[2].Text}', '{item.SubItems[0].Text}')";
                con.Execute(commandText, out output);
            }

            if (con != null)
                con.Close();
            PopUp.Dispose();
            return true;
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
                MessageBox.Show($"Error al conectar con {selectedMachine.Item1}.\n" +
                    $" Verificar que el dispositivo se encuentre conectado a la red o que la configuracion sea correcta.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                ConnectButton.Text = "Desconectar";
                ConnectButton.BackColor = Color.LightGreen;
                DLLogsthisMachine.Text += MachineComboBox.SelectedItem.ToString();
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
            foreach (var ip in IPList)
            {
                if (!MachConn.Connect(ip.Item1, ip.Item2, ip.Item3))
                {
                    Task.Run(() => MessageBox.Show($"Error al conectar con {ip.Item1}. Verificar que el dispositivo se encuentre conectado a la red.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error));
                    return;
                }
                else
                {
                    MachConn.DownloadAttendance(true);
                    SaveLogs();
                    MachConn.Disconnect();
                }
            }
        }

        private void SaveLogs()
        {
            var connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                Config.initconf.DatabasePath + "Descargas.mdb; Jet OLEDB:Database Password=u9120bkb;";
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
                    $" VALUES('{Log.ID}', '{LogDateTime.ToShortDateString()}', '{LogDateTime.ToShortTimeString()}', '{inoutType}', " +
                    $"'{MachineComboBox.Items[CurrentConnectedIndex]}', '{today.ToShortDateString()}', '{today.ToShortTimeString()}')";

                    command.ExecuteNonQuery();

                    LogsFile.WriteLine($"{Log.ID.PadLeft(8, '0')} {LogDateTime.ToString("dd/MM/yyyy")} {LogDateTime.ToString("HH:mm")}" +
                        $" {inoutType}   {(CurrentConnectedIndex + 1).ToString().PadLeft(3, '0')}");
                }
                LogsFile.Close();
                connection.Close();
                connection.Dispose();

            }
        }

        private void DLLogsAllMachines_Click(object sender, EventArgs e)
        {
            DownloadLogsFromAllMachines();
        }

        private void DLLogsthisMachine_Click(object sender, EventArgs e)
        {
            if (!MachConn.isConnected())
                return;
            var eraseAfter = isClearAllLogs.Checked;
            MachConn.DownloadAttendance(eraseAfter);
            UpdateLogsListview();
            SaveLogs();
        }

        private void UpdateLogsListview()
        {
            LogsListview.Items.Clear();
            foreach (var Log in MachConn.attendanceRecords)
            {
                var tmpdata = new ListViewItem(Log.ToStringArray());
                LogsListview.Items.Add(tmpdata);
            }
        }

        #endregion

        #region User Management Events

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (MachConn.userInfo.Count < 1)
                return;

            var users2delete = UsersListview.SelectedItems;

            foreach (ListViewItem user in users2delete)
            {
                if (user.SubItems[2].Text != "0")
                    continue;
                MachConn.DeleteUser(user.SubItems[0].Text);
            }

            UpdateUsersListview();
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            NewUser PopUp = new();
            this.AddOwnedForm(PopUp);
            DialogResult dialogresult = PopUp.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                string Name = "";
                string ID = "";
                PopUp.GetData(ref ID, ref Name);
                MachConn.AddUser(ID, Name);
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
            UpdateUsersListview();
        }

        private void UpdateUsersListview()
        {
            UsersListview.Items.Clear();
            foreach (var user in MachConn.userInfo)
            {
                var tmpdata = new ListViewItem(user.ToStringArray());
                UsersListview.Items.Add(tmpdata);
            }
        }

        #endregion

        private void UsersListview_SizeChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;


            var workingWidth = listView.Width;
            var col1 = 0.25;
            var col2 = 0.50;
            var col3 = 0.25;


            listView.Columns[0].Width = (int)(workingWidth * col1);
            listView.Columns[1].Width = (int)(workingWidth * col2);
            listView.Columns[2].Width = (int)(workingWidth * col3);
        }

        private void LogsListview_SizeChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;


            var workingWidth = listView.Width;
            var col1 = 0.25;
            var col2 = 0.50;
            var col3 = 0.25;


            listView.Columns[0].Width = (int)(workingWidth * col1);
            listView.Columns[1].Width = (int)(workingWidth * col2);
            listView.Columns[2].Width = (int)(workingWidth * col3);
        }
    }

}