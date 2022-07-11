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
            this.MDLTabControl = new System.Windows.Forms.TabControl();
            this.MConnectionTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RelojLabel = new System.Windows.Forms.Label();
            this.MachineComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.MUserMangTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.DLUsers = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.MLogsMangTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DLLogsthisMachine = new System.Windows.Forms.Button();
            this.DLLogsAllMachines = new System.Windows.Forms.Button();
            this.LogsListBox = new System.Windows.Forms.ListBox();
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
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.DeveloperName = new System.Windows.Forms.Label();
            this.MDLTabControl.SuspendLayout();
            this.MConnectionTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.MUserMangTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MLogsMangTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.ConfigTab.SuspendLayout();
            this.LayoutConfigTab.SuspendLayout();
            this.LayoutTimeConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // MDLTabControl
            // 
            this.MDLTabControl.Controls.Add(this.MConnectionTab);
            this.MDLTabControl.Controls.Add(this.MUserMangTab);
            this.MDLTabControl.Controls.Add(this.MLogsMangTab);
            this.MDLTabControl.Controls.Add(this.ConfigTab);
            this.MDLTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MDLTabControl.Location = new System.Drawing.Point(0, 0);
            this.MDLTabControl.Name = "MDLTabControl";
            this.MDLTabControl.SelectedIndex = 0;
            this.MDLTabControl.Size = new System.Drawing.Size(603, 645);
            this.MDLTabControl.TabIndex = 0;
            // 
            // MConnectionTab
            // 
            this.MConnectionTab.Controls.Add(this.flowLayoutPanel1);
            this.MConnectionTab.Location = new System.Drawing.Point(4, 24);
            this.MConnectionTab.Name = "MConnectionTab";
            this.MConnectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.MConnectionTab.Size = new System.Drawing.Size(595, 617);
            this.MConnectionTab.TabIndex = 0;
            this.MConnectionTab.Text = "Conexion";
            this.MConnectionTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.RelojLabel);
            this.flowLayoutPanel1.Controls.Add(this.MachineComboBox);
            this.flowLayoutPanel1.Controls.Add(this.ConnectButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(589, 611);
            this.flowLayoutPanel1.TabIndex = 2;
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
            this.ConnectButton.BackColor = System.Drawing.Color.Salmon;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectButton.Location = new System.Drawing.Point(174, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Conectar";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // MUserMangTab
            // 
            this.MUserMangTab.Controls.Add(this.tableLayoutPanel2);
            this.MUserMangTab.Location = new System.Drawing.Point(4, 24);
            this.MUserMangTab.Name = "MUserMangTab";
            this.MUserMangTab.Padding = new System.Windows.Forms.Padding(3);
            this.MUserMangTab.Size = new System.Drawing.Size(595, 617);
            this.MUserMangTab.TabIndex = 2;
            this.MUserMangTab.Text = "AB de Usuarios";
            this.MUserMangTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.UsersListBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.DLUsers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeleteUserButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.NewUserButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(589, 611);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // UsersListBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.UsersListBox, 2);
            this.UsersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 15;
            this.UsersListBox.Location = new System.Drawing.Point(3, 75);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(583, 533);
            this.UsersListBox.TabIndex = 4;
            // 
            // DLUsers
            // 
            this.DLUsers.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.DLUsers, 2);
            this.DLUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DLUsers.Location = new System.Drawing.Point(3, 3);
            this.DLUsers.MaximumSize = new System.Drawing.Size(0, 30);
            this.DLUsers.Name = "DLUsers";
            this.DLUsers.Size = new System.Drawing.Size(583, 30);
            this.DLUsers.TabIndex = 0;
            this.DLUsers.Text = "Descargar Usuarios";
            this.DLUsers.UseVisualStyleBackColor = true;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.AutoSize = true;
            this.DeleteUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteUserButton.Location = new System.Drawing.Point(297, 39);
            this.DeleteUserButton.MaximumSize = new System.Drawing.Size(0, 30);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(289, 30);
            this.DeleteUserButton.TabIndex = 1;
            this.DeleteUserButton.Text = "Eliminar usuario seleccionado";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // NewUserButton
            // 
            this.NewUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewUserButton.Location = new System.Drawing.Point(3, 39);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(288, 30);
            this.NewUserButton.TabIndex = 3;
            this.NewUserButton.Text = "Agregar Usuario";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // MLogsMangTab
            // 
            this.MLogsMangTab.Controls.Add(this.tableLayoutPanel3);
            this.MLogsMangTab.Location = new System.Drawing.Point(4, 24);
            this.MLogsMangTab.Name = "MLogsMangTab";
            this.MLogsMangTab.Padding = new System.Windows.Forms.Padding(3);
            this.MLogsMangTab.Size = new System.Drawing.Size(595, 617);
            this.MLogsMangTab.TabIndex = 3;
            this.MLogsMangTab.Text = "Registros";
            this.MLogsMangTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DLLogsthisMachine, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DLLogsAllMachines, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LogsListBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.isClearAllLogs, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(589, 611);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // DLLogsthisMachine
            // 
            this.DLLogsthisMachine.AutoSize = true;
            this.DLLogsthisMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DLLogsthisMachine.Location = new System.Drawing.Point(3, 3);
            this.DLLogsthisMachine.MaximumSize = new System.Drawing.Size(0, 30);
            this.DLLogsthisMachine.Name = "DLLogsthisMachine";
            this.DLLogsthisMachine.Size = new System.Drawing.Size(288, 30);
            this.DLLogsthisMachine.TabIndex = 7;
            this.DLLogsthisMachine.Text = "Descargar registros de este reloj";
            this.DLLogsthisMachine.UseVisualStyleBackColor = true;
            this.DLLogsthisMachine.Click += new System.EventHandler(this.DLLogsthisMachine_Click);
            // 
            // DLLogsAllMachines
            // 
            this.DLLogsAllMachines.AutoSize = true;
            this.DLLogsAllMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DLLogsAllMachines.Location = new System.Drawing.Point(297, 3);
            this.DLLogsAllMachines.MaximumSize = new System.Drawing.Size(0, 30);
            this.DLLogsAllMachines.Name = "DLLogsAllMachines";
            this.DLLogsAllMachines.Size = new System.Drawing.Size(289, 30);
            this.DLLogsAllMachines.TabIndex = 8;
            this.DLLogsAllMachines.Text = "Descargar registros de todos los relojes";
            this.DLLogsAllMachines.UseVisualStyleBackColor = true;
            this.DLLogsAllMachines.Click += new System.EventHandler(this.DLLogsAllMachines_Click);
            // 
            // LogsListBox
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.LogsListBox, 2);
            this.LogsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsListBox.FormattingEnabled = true;
            this.LogsListBox.ItemHeight = 15;
            this.LogsListBox.Location = new System.Drawing.Point(3, 64);
            this.LogsListBox.Name = "LogsListBox";
            this.LogsListBox.Size = new System.Drawing.Size(583, 544);
            this.LogsListBox.TabIndex = 0;
            // 
            // isClearAllLogs
            // 
            this.isClearAllLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isClearAllLogs.AutoSize = true;
            this.isClearAllLogs.Checked = true;
            this.isClearAllLogs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel3.SetColumnSpan(this.isClearAllLogs, 2);
            this.isClearAllLogs.Location = new System.Drawing.Point(204, 39);
            this.isClearAllLogs.Name = "isClearAllLogs";
            this.isClearAllLogs.Size = new System.Drawing.Size(180, 19);
            this.isClearAllLogs.TabIndex = 9;
            this.isClearAllLogs.Text = "Limpiar registros al descargar";
            this.isClearAllLogs.UseVisualStyleBackColor = true;
            // 
            // ConfigTab
            // 
            this.ConfigTab.Controls.Add(this.LayoutConfigTab);
            this.ConfigTab.Location = new System.Drawing.Point(4, 24);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigTab.Size = new System.Drawing.Size(595, 617);
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
            this.LayoutConfigTab.Controls.Add(this.DeveloperLabel, 0, 5);
            this.LayoutConfigTab.Controls.Add(this.DeveloperName, 1, 5);
            this.LayoutConfigTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutConfigTab.Location = new System.Drawing.Point(3, 3);
            this.LayoutConfigTab.Name = "LayoutConfigTab";
            this.LayoutConfigTab.RowCount = 6;
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutConfigTab.Size = new System.Drawing.Size(589, 611);
            this.LayoutConfigTab.TabIndex = 0;
            // 
            // MachineQuant
            // 
            this.MachineQuant.AutoSize = true;
            this.MachineQuant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineQuant.Location = new System.Drawing.Point(297, 42);
            this.MachineQuant.Name = "MachineQuant";
            this.MachineQuant.Size = new System.Drawing.Size(289, 36);
            this.MachineQuant.TabIndex = 20;
            this.MachineQuant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogsDirectory
            // 
            this.LogsDirectory.AutoSize = true;
            this.LogsDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsDirectory.Location = new System.Drawing.Point(297, 150);
            this.LogsDirectory.MaximumSize = new System.Drawing.Size(0, 39);
            this.LogsDirectory.MinimumSize = new System.Drawing.Size(0, 36);
            this.LogsDirectory.Name = "LogsDirectory";
            this.LogsDirectory.Size = new System.Drawing.Size(289, 36);
            this.LogsDirectory.TabIndex = 18;
            this.LogsDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DBDirectory
            // 
            this.DBDirectory.AutoSize = true;
            this.DBDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBDirectory.Location = new System.Drawing.Point(297, 114);
            this.DBDirectory.Name = "DBDirectory";
            this.DBDirectory.Size = new System.Drawing.Size(289, 36);
            this.DBDirectory.TabIndex = 17;
            this.DBDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyName.Location = new System.Drawing.Point(297, 78);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(289, 36);
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
            this.LogsDirectoryLabel.Size = new System.Drawing.Size(288, 36);
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
            this.DBDirectoryLabel.Size = new System.Drawing.Size(288, 36);
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
            this.CompanyNameLabel.Size = new System.Drawing.Size(288, 36);
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
            this.MachineQuantLabel.Size = new System.Drawing.Size(288, 36);
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
            this.DLTimeLabel.Size = new System.Drawing.Size(288, 39);
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
            this.LayoutTimeConfig.Location = new System.Drawing.Point(297, 3);
            this.LayoutTimeConfig.MaximumSize = new System.Drawing.Size(0, 39);
            this.LayoutTimeConfig.MinimumSize = new System.Drawing.Size(0, 36);
            this.LayoutTimeConfig.Name = "LayoutTimeConfig";
            this.LayoutTimeConfig.RowCount = 1;
            this.LayoutTimeConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutTimeConfig.Size = new System.Drawing.Size(289, 36);
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
            this.SetTimeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetTimeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetTimeButton.Location = new System.Drawing.Point(109, 3);
            this.SetTimeButton.MaximumSize = new System.Drawing.Size(0, 30);
            this.SetTimeButton.MinimumSize = new System.Drawing.Size(0, 30);
            this.SetTimeButton.Name = "SetTimeButton";
            this.SetTimeButton.Size = new System.Drawing.Size(177, 30);
            this.SetTimeButton.TabIndex = 2;
            this.SetTimeButton.Text = "Aplicar cambios";
            this.SetTimeButton.UseVisualStyleBackColor = true;
            this.SetTimeButton.Click += new System.EventHandler(this.SetTimeButton_Click);
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.Location = new System.Drawing.Point(115, 391);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(63, 15);
            this.DeveloperLabel.TabIndex = 21;
            this.DeveloperLabel.Text = "Desarrollo:";
            // 
            // DeveloperName
            // 
            this.DeveloperName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeveloperName.AutoSize = true;
            this.DeveloperName.Location = new System.Drawing.Point(323, 391);
            this.DeveloperName.Name = "DeveloperName";
            this.DeveloperName.Size = new System.Drawing.Size(236, 15);
            this.DeveloperName.TabIndex = 22;
            this.DeveloperName.Text = "Agustin Luis Gullino de Informatica Integral";
            // 
            // MachineDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 645);
            this.Controls.Add(this.MDLTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MachineDL";
            this.Text = "Descargador de Relojes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MachineDL_FormClosing);
            this.MDLTabControl.ResumeLayout(false);
            this.MConnectionTab.ResumeLayout(false);
            this.MConnectionTab.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.MUserMangTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.MLogsMangTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ConfigTab.ResumeLayout(false);
            this.LayoutConfigTab.ResumeLayout(false);
            this.LayoutConfigTab.PerformLayout();
            this.LayoutTimeConfig.ResumeLayout(false);
            this.LayoutTimeConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MDLTabControl;
        private TabPage MConnectionTab;
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
        private TabPage MUserMangTab;
        private TabPage MLogsMangTab;
        private Button DLLogsthisMachine;
        private Button DLLogsAllMachines;
        private CheckBox isClearAllLogs;
        private TableLayoutPanel tableLayoutPanel2;
        private Button DLUsers;
        private Button DeleteUserButton;
        private Button NewUserButton;
        private ListBox UsersListBox;
        private TableLayoutPanel tableLayoutPanel3;
        private ListBox LogsListBox;
        private Label DeveloperLabel;
        private Label DeveloperName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label RelojLabel;
        private ComboBox MachineComboBox;
        private Button ConnectButton;
    }
}