namespace ZKTecoDown
{
    partial class MachineDL
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineDL));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MDLTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ConectionBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RelojLabel = new System.Windows.Forms.Label();
            this.MachineComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConnectionCheckBox = new System.Windows.Forms.CheckBox();
            this.UsersBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DLUsers = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.AttendanceBox = new System.Windows.Forms.GroupBox();
            this.LogsListBox = new System.Windows.Forms.ListBox();
            this.DLthisMachine = new System.Windows.Forms.Button();
            this.DLAllMachines = new System.Windows.Forms.Button();
            this.isClearAllLogs = new System.Windows.Forms.CheckBox();
            this.ConfigTab = new System.Windows.Forms.TabPage();
            this.LayoutConfigTab = new System.Windows.Forms.TableLayoutPanel();
            this.MachineQuant = new System.Windows.Forms.Label();
            this.LogsDirectory = new System.Windows.Forms.Label();
            this.DBDirectory = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.Label();
            this.LogsDirectoryLabel = new System.Windows.Forms.Label();
            this.DBDirectoryLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.MachineQuantLabel = new System.Windows.Forms.Label();
            this.DLTimeLabel = new System.Windows.Forms.Label();
            this.LayoutTimeConfig = new System.Windows.Forms.TableLayoutPanel();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.SetTimeButton = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.MDLTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ConectionBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.UsersBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.AttendanceBox.SuspendLayout();
            this.ConfigTab.SuspendLayout();
            this.LayoutConfigTab.SuspendLayout();
            this.LayoutTimeConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MDLTab);
            this.TabControl.Controls.Add(this.ConfigTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(864, 603);
            this.TabControl.TabIndex = 0;
            // 
            // MDLTab
            // 
            this.MDLTab.Controls.Add(this.tableLayoutPanel1);
            this.MDLTab.Location = new System.Drawing.Point(4, 24);
            this.MDLTab.Name = "MDLTab";
            this.MDLTab.Padding = new System.Windows.Forms.Padding(3);
            this.MDLTab.Size = new System.Drawing.Size(856, 575);
            this.MDLTab.TabIndex = 0;
            this.MDLTab.Text = "Descargador";
            this.MDLTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ConectionBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UsersBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AttendanceBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DLthisMachine, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DLAllMachines, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.isClearAllLogs, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 569);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ConectionBox
            // 
            this.ConectionBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ConectionBox, 2);
            this.ConectionBox.Controls.Add(this.flowLayoutPanel1);
            this.ConectionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConectionBox.Location = new System.Drawing.Point(3, 3);
            this.ConectionBox.Name = "ConectionBox";
            this.ConectionBox.Size = new System.Drawing.Size(844, 51);
            this.ConectionBox.TabIndex = 0;
            this.ConectionBox.TabStop = false;
            this.ConectionBox.Text = "Conexiones";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.RelojLabel);
            this.flowLayoutPanel1.Controls.Add(this.MachineComboBox);
            this.flowLayoutPanel1.Controls.Add(this.ConnectButton);
            this.flowLayoutPanel1.Controls.Add(this.ConnectionCheckBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(838, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // RelojLabel
            // 
            this.RelojLabel.AutoSize = true;
            this.RelojLabel.Location = new System.Drawing.Point(5, 7);
            this.RelojLabel.Margin = new System.Windows.Forms.Padding(5, 7, 3, 0);
            this.RelojLabel.Name = "RelojLabel";
            this.RelojLabel.Size = new System.Drawing.Size(36, 15);
            this.RelojLabel.TabIndex = 0;
            this.RelojLabel.Text = "Reloj:";
            // 
            // MachineComboBox
            // 
            this.MachineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MachineComboBox.FormattingEnabled = true;
            this.MachineComboBox.Location = new System.Drawing.Point(47, 3);
            this.MachineComboBox.Name = "MachineComboBox";
            this.MachineComboBox.Size = new System.Drawing.Size(121, 23);
            this.MachineComboBox.TabIndex = 1;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(174, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Conectar";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectionCheckBox
            // 
            this.ConnectionCheckBox.AutoSize = true;
            this.ConnectionCheckBox.Enabled = false;
            this.ConnectionCheckBox.Location = new System.Drawing.Point(255, 7);
            this.ConnectionCheckBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.ConnectionCheckBox.Name = "ConnectionCheckBox";
            this.ConnectionCheckBox.Size = new System.Drawing.Size(84, 19);
            this.ConnectionCheckBox.TabIndex = 3;
            this.ConnectionCheckBox.Text = "Conectado";
            this.ConnectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsersBox
            // 
            this.UsersBox.Controls.Add(this.tableLayoutPanel2);
            this.UsersBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersBox.Location = new System.Drawing.Point(3, 60);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(419, 445);
            this.UsersBox.TabIndex = 1;
            this.UsersBox.TabStop = false;
            this.UsersBox.Text = "Usuarios";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DLUsers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeleteUser, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.UsersListBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 423);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DLUsers
            // 
            this.DLUsers.AutoSize = true;
            this.DLUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DLUsers.Location = new System.Drawing.Point(3, 3);
            this.DLUsers.MaximumSize = new System.Drawing.Size(0, 30);
            this.DLUsers.Name = "DLUsers";
            this.DLUsers.Size = new System.Drawing.Size(200, 30);
            this.DLUsers.TabIndex = 0;
            this.DLUsers.Text = "Descargar Usuarios";
            this.DLUsers.UseVisualStyleBackColor = true;
            this.DLUsers.Click += new System.EventHandler(this.DLUsers_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.AutoSize = true;
            this.DeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteUser.Location = new System.Drawing.Point(209, 3);
            this.DeleteUser.MaximumSize = new System.Drawing.Size(0, 30);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(201, 30);
            this.DeleteUser.TabIndex = 1;
            this.DeleteUser.Text = "Eliminar usuario seleccionado";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // UsersListBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.UsersListBox, 2);
            this.UsersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 15;
            this.UsersListBox.Location = new System.Drawing.Point(3, 39);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(407, 381);
            this.UsersListBox.TabIndex = 2;
            // 
            // AttendanceBox
            // 
            this.AttendanceBox.AutoSize = true;
            this.AttendanceBox.Controls.Add(this.LogsListBox);
            this.AttendanceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttendanceBox.Location = new System.Drawing.Point(428, 60);
            this.AttendanceBox.Name = "AttendanceBox";
            this.AttendanceBox.Size = new System.Drawing.Size(419, 445);
            this.AttendanceBox.TabIndex = 2;
            this.AttendanceBox.TabStop = false;
            this.AttendanceBox.Text = "Registros de Asistencia";
            // 
            // LogsListBox
            // 
            this.LogsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsListBox.FormattingEnabled = true;
            this.LogsListBox.ItemHeight = 15;
            this.LogsListBox.Location = new System.Drawing.Point(3, 19);
            this.LogsListBox.Name = "LogsListBox";
            this.LogsListBox.Size = new System.Drawing.Size(413, 423);
            this.LogsListBox.TabIndex = 0;
            // 
            // DLthisMachine
            // 
            this.DLthisMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DLthisMachine.AutoSize = true;
            this.DLthisMachine.Location = new System.Drawing.Point(121, 511);
            this.DLthisMachine.MaximumSize = new System.Drawing.Size(0, 30);
            this.DLthisMachine.Name = "DLthisMachine";
            this.DLthisMachine.Size = new System.Drawing.Size(183, 30);
            this.DLthisMachine.TabIndex = 3;
            this.DLthisMachine.Text = "Descargar registros de este reloj";
            this.DLthisMachine.UseVisualStyleBackColor = true;
            this.DLthisMachine.Click += new System.EventHandler(this.DLthisMachine_Click);
            // 
            // DLAllMachines
            // 
            this.DLAllMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DLAllMachines.AutoSize = true;
            this.DLAllMachines.Location = new System.Drawing.Point(527, 511);
            this.DLAllMachines.MaximumSize = new System.Drawing.Size(0, 30);
            this.DLAllMachines.Name = "DLAllMachines";
            this.DLAllMachines.Size = new System.Drawing.Size(221, 30);
            this.DLAllMachines.TabIndex = 4;
            this.DLAllMachines.Text = "Descargar registros de todos los relojes";
            this.DLAllMachines.UseVisualStyleBackColor = true;
            // 
            // isClearAllLogs
            // 
            this.isClearAllLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.isClearAllLogs.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.isClearAllLogs, 2);
            this.isClearAllLogs.Location = new System.Drawing.Point(335, 547);
            this.isClearAllLogs.Name = "isClearAllLogs";
            this.isClearAllLogs.Size = new System.Drawing.Size(180, 19);
            this.isClearAllLogs.TabIndex = 5;
            this.isClearAllLogs.Text = "Limpiar registros al descargar";
            this.isClearAllLogs.UseVisualStyleBackColor = true;
            // 
            // ConfigTab
            // 
            this.ConfigTab.Controls.Add(this.LayoutConfigTab);
            this.ConfigTab.Location = new System.Drawing.Point(4, 24);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigTab.Size = new System.Drawing.Size(856, 575);
            this.ConfigTab.TabIndex = 1;
            this.ConfigTab.Text = "Configuracion";
            this.ConfigTab.UseVisualStyleBackColor = true;
            // 
            // LayoutConfigTab
            // 
            this.LayoutConfigTab.ColumnCount = 2;
            this.LayoutConfigTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutConfigTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutConfigTab.Controls.Add(this.MachineQuant, 1, 1);
            this.LayoutConfigTab.Controls.Add(this.LogsDirectory, 1, 4);
            this.LayoutConfigTab.Controls.Add(this.DBDirectory, 1, 3);
            this.LayoutConfigTab.Controls.Add(this.CompanyName, 1, 2);
            this.LayoutConfigTab.Controls.Add(this.LogsDirectoryLabel, 0, 4);
            this.LayoutConfigTab.Controls.Add(this.DBDirectoryLabel, 0, 3);
            this.LayoutConfigTab.Controls.Add(this.CompanyNameLabel, 0, 2);
            this.LayoutConfigTab.Controls.Add(this.MachineQuantLabel, 0, 1);
            this.LayoutConfigTab.Controls.Add(this.DLTimeLabel, 0, 0);
            this.LayoutConfigTab.Controls.Add(this.LayoutTimeConfig, 1, 0);
            this.LayoutConfigTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutConfigTab.Location = new System.Drawing.Point(3, 3);
            this.LayoutConfigTab.Name = "LayoutConfigTab";
            this.LayoutConfigTab.RowCount = 5;
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.Size = new System.Drawing.Size(850, 569);
            this.LayoutConfigTab.TabIndex = 0;
            // 
            // MachineQuant
            // 
            this.MachineQuant.AutoSize = true;
            this.MachineQuant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineQuant.Location = new System.Drawing.Point(428, 42);
            this.MachineQuant.Name = "MachineQuant";
            this.MachineQuant.Size = new System.Drawing.Size(419, 36);
            this.MachineQuant.TabIndex = 20;
            this.MachineQuant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogsDirectory
            // 
            this.LogsDirectory.AutoSize = true;
            this.LogsDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsDirectory.Location = new System.Drawing.Point(428, 150);
            this.LogsDirectory.MaximumSize = new System.Drawing.Size(0, 39);
            this.LogsDirectory.MinimumSize = new System.Drawing.Size(0, 36);
            this.LogsDirectory.Name = "LogsDirectory";
            this.LogsDirectory.Size = new System.Drawing.Size(419, 39);
            this.LogsDirectory.TabIndex = 18;
            this.LogsDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DBDirectory
            // 
            this.DBDirectory.AutoSize = true;
            this.DBDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBDirectory.Location = new System.Drawing.Point(428, 114);
            this.DBDirectory.Name = "DBDirectory";
            this.DBDirectory.Size = new System.Drawing.Size(419, 36);
            this.DBDirectory.TabIndex = 17;
            this.DBDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyName.Location = new System.Drawing.Point(428, 78);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(419, 36);
            this.CompanyName.TabIndex = 16;
            this.CompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogsDirectoryLabel
            // 
            this.LogsDirectoryLabel.AutoSize = true;
            this.LogsDirectoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsDirectoryLabel.Location = new System.Drawing.Point(3, 150);
            this.LogsDirectoryLabel.MaximumSize = new System.Drawing.Size(0, 39);
            this.LogsDirectoryLabel.MinimumSize = new System.Drawing.Size(0, 36);
            this.LogsDirectoryLabel.Name = "LogsDirectoryLabel";
            this.LogsDirectoryLabel.Size = new System.Drawing.Size(419, 39);
            this.LogsDirectoryLabel.TabIndex = 14;
            this.LogsDirectoryLabel.Text = "Directorio de guardado de registros";
            this.LogsDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DBDirectoryLabel
            // 
            this.DBDirectoryLabel.AutoSize = true;
            this.DBDirectoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBDirectoryLabel.Location = new System.Drawing.Point(3, 114);
            this.DBDirectoryLabel.MaximumSize = new System.Drawing.Size(0, 39);
            this.DBDirectoryLabel.MinimumSize = new System.Drawing.Size(0, 36);
            this.DBDirectoryLabel.Name = "DBDirectoryLabel";
            this.DBDirectoryLabel.Size = new System.Drawing.Size(419, 36);
            this.DBDirectoryLabel.TabIndex = 12;
            this.DBDirectoryLabel.Text = "Directorio de la Base de Datos";
            this.DBDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyNameLabel.Location = new System.Drawing.Point(3, 78);
            this.CompanyNameLabel.MaximumSize = new System.Drawing.Size(0, 39);
            this.CompanyNameLabel.MinimumSize = new System.Drawing.Size(0, 36);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(419, 36);
            this.CompanyNameLabel.TabIndex = 9;
            this.CompanyNameLabel.Text = "Empresa";
            this.CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MachineQuantLabel
            // 
            this.MachineQuantLabel.AutoSize = true;
            this.MachineQuantLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineQuantLabel.Location = new System.Drawing.Point(3, 42);
            this.MachineQuantLabel.MaximumSize = new System.Drawing.Size(0, 39);
            this.MachineQuantLabel.MinimumSize = new System.Drawing.Size(0, 36);
            this.MachineQuantLabel.Name = "MachineQuantLabel";
            this.MachineQuantLabel.Size = new System.Drawing.Size(419, 36);
            this.MachineQuantLabel.TabIndex = 7;
            this.MachineQuantLabel.Text = "Cantidad de Relojes permitida";
            this.MachineQuantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DLTimeLabel
            // 
            this.DLTimeLabel.AutoSize = true;
            this.DLTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DLTimeLabel.Location = new System.Drawing.Point(3, 0);
            this.DLTimeLabel.MaximumSize = new System.Drawing.Size(0, 39);
            this.DLTimeLabel.MinimumSize = new System.Drawing.Size(0, 36);
            this.DLTimeLabel.Name = "DLTimeLabel";
            this.DLTimeLabel.Size = new System.Drawing.Size(419, 39);
            this.DLTimeLabel.TabIndex = 2;
            this.DLTimeLabel.Text = "Hora de descarga programada";
            this.DLTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayoutTimeConfig
            // 
            this.LayoutTimeConfig.ColumnCount = 2;
            this.LayoutTimeConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutTimeConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutTimeConfig.Controls.Add(this.TimePicker, 0, 0);
            this.LayoutTimeConfig.Controls.Add(this.SetTimeButton, 1, 0);
            this.LayoutTimeConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutTimeConfig.Location = new System.Drawing.Point(428, 3);
            this.LayoutTimeConfig.MaximumSize = new System.Drawing.Size(0, 39);
            this.LayoutTimeConfig.MinimumSize = new System.Drawing.Size(0, 36);
            this.LayoutTimeConfig.Name = "LayoutTimeConfig";
            this.LayoutTimeConfig.RowCount = 1;
            this.LayoutTimeConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutTimeConfig.Size = new System.Drawing.Size(419, 36);
            this.LayoutTimeConfig.TabIndex = 19;
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "HH:mm";
            this.TimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TimePicker.Location = new System.Drawing.Point(3, 3);
            this.TimePicker.MinimumSize = new System.Drawing.Size(100, 30);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(100, 30);
            this.TimePicker.TabIndex = 1;
            this.TimePicker.Value = new System.DateTime(2022, 9, 7, 0, 0, 0, 0);
            // 
            // SetTimeButton
            // 
            this.SetTimeButton.AutoSize = true;
            this.SetTimeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetTimeButton.Location = new System.Drawing.Point(109, 3);
            this.SetTimeButton.MaximumSize = new System.Drawing.Size(0, 30);
            this.SetTimeButton.MinimumSize = new System.Drawing.Size(0, 30);
            this.SetTimeButton.Name = "SetTimeButton";
            this.SetTimeButton.Size = new System.Drawing.Size(307, 30);
            this.SetTimeButton.TabIndex = 2;
            this.SetTimeButton.Text = "Aplicar cambios";
            this.SetTimeButton.UseVisualStyleBackColor = true;
            this.SetTimeButton.Click += new System.EventHandler(this.SetTimeButton_Click);
            // 
            // MachineDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 603);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MachineDL";
            this.Text = "Descargador de Relojes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MachineDL_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.TabControl.ResumeLayout(false);
            this.MDLTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ConectionBox.ResumeLayout(false);
            this.ConectionBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.UsersBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.AttendanceBox.ResumeLayout(false);
            this.ConfigTab.ResumeLayout(false);
            this.LayoutConfigTab.ResumeLayout(false);
            this.LayoutConfigTab.PerformLayout();
            this.LayoutTimeConfig.ResumeLayout(false);
            this.LayoutTimeConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControl;
        private TabPage MDLTab;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox ConectionBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label RelojLabel;
        private ComboBox MachineComboBox;
        private Button ConnectButton;
        private CheckBox ConnectionCheckBox;
        private GroupBox UsersBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button DLUsers;
        private Button DeleteUser;
        private ListBox UsersListBox;
        private GroupBox AttendanceBox;
        private ListBox LogsListBox;
        private Button DLthisMachine;
        private Button DLAllMachines;
        private CheckBox isClearAllLogs;
        private TabPage ConfigTab;
        private DateTimePicker TimePicker;
        private TableLayoutPanel LayoutConfigTab;
        private Label LogsDirectory;
        private Label DBDirectory;
        private Label CompanyName;
        private Label LogsDirectoryLabel;
        private Label DBDirectoryLabel;
        private Label CompanyNameLabel;
        private Label MachineQuantLabel;
        private Label DLTimeLabel;
        private Label MachineQuant;
        private TableLayoutPanel LayoutTimeConfig;
        private Button SetTimeButton;
    }
}