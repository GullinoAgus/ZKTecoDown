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
            MDLTabControl = new TabControl();
            MConnectionTab = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            DLLogsAllMachines = new Button();
            RelojLabel = new Label();
            ConnectButton = new Button();
            MachineComboBox = new ComboBox();
            MUserMangTab = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            DLUsers = new Button();
            DeleteUserButton = new Button();
            NewUserButton = new Button();
            UsersListview = new ListView();
            IDHeader = new ColumnHeader();
            NameHeader = new ColumnHeader();
            PrivilegeHeader = new ColumnHeader();
            MLogsMangTab = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            DLLogsthisMachine = new Button();
            isClearAllLogs = new CheckBox();
            LogsListview = new ListView();
            IDLogsHeader = new ColumnHeader();
            InOutHeader = new ColumnHeader();
            DateLogHeader = new ColumnHeader();
            ConfigTab = new TabPage();
            LayoutConfigTab = new TableLayoutPanel();
            MachineQuant = new Label();
            LogsDirectory = new Label();
            DBDirectory = new Label();
            Companyname = new Label();
            LogsDirectoryLabel = new Label();
            DBDirectoryLabel = new Label();
            CompanyNameLabel = new Label();
            MachineQuantLabel = new Label();
            DeveloperLabel = new Label();
            DeveloperName = new Label();
            MDLTabControl.SuspendLayout();
            MConnectionTab.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            MUserMangTab.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            MLogsMangTab.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ConfigTab.SuspendLayout();
            LayoutConfigTab.SuspendLayout();
            SuspendLayout();
            // 
            // MDLTabControl
            // 
            MDLTabControl.Controls.Add(MConnectionTab);
            MDLTabControl.Controls.Add(MUserMangTab);
            MDLTabControl.Controls.Add(MLogsMangTab);
            MDLTabControl.Controls.Add(ConfigTab);
            MDLTabControl.Dock = DockStyle.Fill;
            MDLTabControl.Location = new Point(0, 0);
            MDLTabControl.Name = "MDLTabControl";
            MDLTabControl.SelectedIndex = 0;
            MDLTabControl.Size = new Size(603, 482);
            MDLTabControl.TabIndex = 0;
            // 
            // MConnectionTab
            // 
            MConnectionTab.Controls.Add(tableLayoutPanel1);
            MConnectionTab.Location = new Point(4, 24);
            MConnectionTab.Name = "MConnectionTab";
            MConnectionTab.Padding = new Padding(3);
            MConnectionTab.Size = new Size(595, 454);
            MConnectionTab.TabIndex = 0;
            MConnectionTab.Text = "Conexion";
            MConnectionTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(DLLogsAllMachines, 0, 1);
            tableLayoutPanel1.Controls.Add(RelojLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(ConnectButton, 2, 0);
            tableLayoutPanel1.Controls.Add(MachineComboBox, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(589, 448);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // DLLogsAllMachines
            // 
            DLLogsAllMachines.AutoSize = true;
            DLLogsAllMachines.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(DLLogsAllMachines, 3);
            DLLogsAllMachines.Dock = DockStyle.Fill;
            DLLogsAllMachines.Location = new Point(3, 32);
            DLLogsAllMachines.MaximumSize = new Size(0, 30);
            DLLogsAllMachines.Name = "DLLogsAllMachines";
            DLLogsAllMachines.Size = new Size(583, 30);
            DLLogsAllMachines.TabIndex = 9;
            DLLogsAllMachines.Text = "Descargar registros de todos los relojes";
            DLLogsAllMachines.UseVisualStyleBackColor = true;
            DLLogsAllMachines.Click += DLLogsAllMachines_Click;
            // 
            // RelojLabel
            // 
            RelojLabel.AutoSize = true;
            RelojLabel.Location = new Point(5, 7);
            RelojLabel.Margin = new Padding(5, 7, 3, 0);
            RelojLabel.MinimumSize = new Size(36, 15);
            RelojLabel.Name = "RelojLabel";
            RelojLabel.Size = new Size(36, 15);
            RelojLabel.TabIndex = 0;
            RelojLabel.Text = "Reloj:";
            // 
            // ConnectButton
            // 
            ConnectButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ConnectButton.BackColor = Color.Salmon;
            ConnectButton.FlatStyle = FlatStyle.Popup;
            ConnectButton.Location = new Point(253, 3);
            ConnectButton.MinimumSize = new Size(100, 23);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(100, 23);
            ConnectButton.TabIndex = 2;
            ConnectButton.Text = "Conectar";
            ConnectButton.UseVisualStyleBackColor = false;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // MachineComboBox
            // 
            MachineComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MachineComboBox.FormattingEnabled = true;
            MachineComboBox.Location = new Point(47, 3);
            MachineComboBox.MinimumSize = new Size(200, 0);
            MachineComboBox.Name = "MachineComboBox";
            MachineComboBox.Size = new Size(200, 23);
            MachineComboBox.TabIndex = 1;
            // 
            // MUserMangTab
            // 
            MUserMangTab.Controls.Add(tableLayoutPanel2);
            MUserMangTab.Location = new Point(4, 24);
            MUserMangTab.Name = "MUserMangTab";
            MUserMangTab.Padding = new Padding(3);
            MUserMangTab.Size = new Size(595, 454);
            MUserMangTab.TabIndex = 2;
            MUserMangTab.Text = "AB de Usuarios";
            MUserMangTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(DLUsers, 0, 0);
            tableLayoutPanel2.Controls.Add(DeleteUserButton, 1, 1);
            tableLayoutPanel2.Controls.Add(NewUserButton, 0, 1);
            tableLayoutPanel2.Controls.Add(UsersListview, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(589, 448);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // DLUsers
            // 
            DLUsers.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(DLUsers, 2);
            DLUsers.Dock = DockStyle.Fill;
            DLUsers.Location = new Point(3, 3);
            DLUsers.MaximumSize = new Size(0, 30);
            DLUsers.Name = "DLUsers";
            DLUsers.Size = new Size(583, 30);
            DLUsers.TabIndex = 0;
            DLUsers.Text = "Descargar Usuarios";
            DLUsers.UseVisualStyleBackColor = true;
            DLUsers.Click += DLUsers_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.AutoSize = true;
            DeleteUserButton.Dock = DockStyle.Fill;
            DeleteUserButton.Location = new Point(297, 39);
            DeleteUserButton.MaximumSize = new Size(0, 30);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(289, 30);
            DeleteUserButton.TabIndex = 1;
            DeleteUserButton.Text = "Eliminar usuario seleccionado";
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // NewUserButton
            // 
            NewUserButton.Dock = DockStyle.Fill;
            NewUserButton.Location = new Point(3, 39);
            NewUserButton.Name = "NewUserButton";
            NewUserButton.Size = new Size(288, 30);
            NewUserButton.TabIndex = 3;
            NewUserButton.Text = "Agregar Usuario";
            NewUserButton.UseVisualStyleBackColor = true;
            NewUserButton.Click += NewUserButton_Click;
            // 
            // UsersListview
            // 
            UsersListview.AllowColumnReorder = true;
            UsersListview.Columns.AddRange(new ColumnHeader[] { IDHeader, NameHeader, PrivilegeHeader });
            tableLayoutPanel2.SetColumnSpan(UsersListview, 2);
            UsersListview.Dock = DockStyle.Fill;
            UsersListview.FullRowSelect = true;
            UsersListview.GridLines = true;
            UsersListview.Location = new Point(3, 75);
            UsersListview.Name = "UsersListview";
            UsersListview.Size = new Size(583, 370);
            UsersListview.TabIndex = 4;
            UsersListview.UseCompatibleStateImageBehavior = false;
            UsersListview.View = View.Details;
            UsersListview.SizeChanged += UsersListview_SizeChanged;
            // 
            // IDHeader
            // 
            IDHeader.Text = "ID";
            IDHeader.Width = 145;
            // 
            // NameHeader
            // 
            NameHeader.Text = "Nombre";
            NameHeader.TextAlign = HorizontalAlignment.Center;
            NameHeader.Width = 291;
            // 
            // PrivilegeHeader
            // 
            PrivilegeHeader.Text = "Privilegios";
            PrivilegeHeader.Width = 145;
            // 
            // MLogsMangTab
            // 
            MLogsMangTab.Controls.Add(tableLayoutPanel3);
            MLogsMangTab.Location = new Point(4, 24);
            MLogsMangTab.Name = "MLogsMangTab";
            MLogsMangTab.Padding = new Padding(3);
            MLogsMangTab.Size = new Size(595, 454);
            MLogsMangTab.TabIndex = 3;
            MLogsMangTab.Text = "Registros";
            MLogsMangTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(DLLogsthisMachine, 0, 0);
            tableLayoutPanel3.Controls.Add(isClearAllLogs, 0, 1);
            tableLayoutPanel3.Controls.Add(LogsListview, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(589, 448);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // DLLogsthisMachine
            // 
            DLLogsthisMachine.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(DLLogsthisMachine, 2);
            DLLogsthisMachine.Dock = DockStyle.Fill;
            DLLogsthisMachine.Location = new Point(3, 3);
            DLLogsthisMachine.MaximumSize = new Size(0, 30);
            DLLogsthisMachine.Name = "DLLogsthisMachine";
            DLLogsthisMachine.Size = new Size(583, 30);
            DLLogsthisMachine.TabIndex = 7;
            DLLogsthisMachine.Text = "Descargar registros del reloj ";
            DLLogsthisMachine.UseVisualStyleBackColor = true;
            DLLogsthisMachine.Click += DLLogsthisMachine_Click;
            // 
            // isClearAllLogs
            // 
            isClearAllLogs.Anchor = AnchorStyles.None;
            isClearAllLogs.AutoSize = true;
            isClearAllLogs.Checked = true;
            isClearAllLogs.CheckState = CheckState.Checked;
            tableLayoutPanel3.SetColumnSpan(isClearAllLogs, 2);
            isClearAllLogs.Location = new Point(208, 39);
            isClearAllLogs.Name = "isClearAllLogs";
            isClearAllLogs.Size = new Size(172, 19);
            isClearAllLogs.TabIndex = 9;
            isClearAllLogs.Text = "Borrar registros al descargar";
            isClearAllLogs.UseVisualStyleBackColor = true;
            // 
            // LogsListview
            // 
            LogsListview.AllowColumnReorder = true;
            LogsListview.Columns.AddRange(new ColumnHeader[] { IDLogsHeader, InOutHeader, DateLogHeader });
            tableLayoutPanel3.SetColumnSpan(LogsListview, 2);
            LogsListview.Dock = DockStyle.Fill;
            LogsListview.FullRowSelect = true;
            LogsListview.GridLines = true;
            LogsListview.Location = new Point(3, 64);
            LogsListview.Name = "LogsListview";
            LogsListview.Size = new Size(583, 381);
            LogsListview.TabIndex = 10;
            LogsListview.UseCompatibleStateImageBehavior = false;
            LogsListview.View = View.Details;
            LogsListview.SizeChanged += LogsListview_SizeChanged;
            // 
            // IDLogsHeader
            // 
            IDLogsHeader.Text = "ID";
            IDLogsHeader.Width = 145;
            // 
            // InOutHeader
            // 
            InOutHeader.Text = "Entrada/Salida";
            InOutHeader.TextAlign = HorizontalAlignment.Center;
            InOutHeader.Width = 291;
            // 
            // DateLogHeader
            // 
            DateLogHeader.Text = "Fecha y hora";
            DateLogHeader.TextAlign = HorizontalAlignment.Center;
            DateLogHeader.Width = 145;
            // 
            // ConfigTab
            // 
            ConfigTab.Controls.Add(LayoutConfigTab);
            ConfigTab.Location = new Point(4, 24);
            ConfigTab.Name = "ConfigTab";
            ConfigTab.Padding = new Padding(3);
            ConfigTab.Size = new Size(595, 454);
            ConfigTab.TabIndex = 1;
            ConfigTab.Text = "Configuracion";
            ConfigTab.UseVisualStyleBackColor = true;
            // 
            // LayoutConfigTab
            // 
            LayoutConfigTab.ColumnCount = 2;
            LayoutConfigTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutConfigTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutConfigTab.Controls.Add(MachineQuant, 1, 1);
            LayoutConfigTab.Controls.Add(LogsDirectory, 1, 4);
            LayoutConfigTab.Controls.Add(DBDirectory, 1, 3);
            LayoutConfigTab.Controls.Add(Companyname, 1, 2);
            LayoutConfigTab.Controls.Add(LogsDirectoryLabel, 0, 4);
            LayoutConfigTab.Controls.Add(DBDirectoryLabel, 0, 3);
            LayoutConfigTab.Controls.Add(CompanyNameLabel, 0, 2);
            LayoutConfigTab.Controls.Add(MachineQuantLabel, 0, 1);
            LayoutConfigTab.Controls.Add(DeveloperLabel, 0, 6);
            LayoutConfigTab.Controls.Add(DeveloperName, 1, 6);
            LayoutConfigTab.Dock = DockStyle.Fill;
            LayoutConfigTab.Location = new Point(3, 3);
            LayoutConfigTab.Name = "LayoutConfigTab";
            LayoutConfigTab.RowCount = 7;
            LayoutConfigTab.RowStyles.Add(new RowStyle());
            LayoutConfigTab.RowStyles.Add(new RowStyle());
            LayoutConfigTab.RowStyles.Add(new RowStyle());
            LayoutConfigTab.RowStyles.Add(new RowStyle());
            LayoutConfigTab.RowStyles.Add(new RowStyle());
            LayoutConfigTab.RowStyles.Add(new RowStyle());
            LayoutConfigTab.RowStyles.Add(new RowStyle());
            LayoutConfigTab.Size = new Size(589, 448);
            LayoutConfigTab.TabIndex = 0;
            // 
            // MachineQuant
            // 
            MachineQuant.AutoSize = true;
            MachineQuant.Dock = DockStyle.Fill;
            MachineQuant.Location = new Point(297, 0);
            MachineQuant.Name = "MachineQuant";
            MachineQuant.Size = new Size(289, 36);
            MachineQuant.TabIndex = 20;
            MachineQuant.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogsDirectory
            // 
            LogsDirectory.AutoSize = true;
            LogsDirectory.Dock = DockStyle.Fill;
            LogsDirectory.Location = new Point(297, 108);
            LogsDirectory.MaximumSize = new Size(0, 39);
            LogsDirectory.MinimumSize = new Size(0, 36);
            LogsDirectory.Name = "LogsDirectory";
            LogsDirectory.Size = new Size(289, 36);
            LogsDirectory.TabIndex = 18;
            LogsDirectory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DBDirectory
            // 
            DBDirectory.AutoSize = true;
            DBDirectory.Dock = DockStyle.Fill;
            DBDirectory.Location = new Point(297, 72);
            DBDirectory.Name = "DBDirectory";
            DBDirectory.Size = new Size(289, 36);
            DBDirectory.TabIndex = 17;
            DBDirectory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Companyname
            // 
            Companyname.AutoSize = true;
            Companyname.Dock = DockStyle.Fill;
            Companyname.Location = new Point(297, 36);
            Companyname.Name = "Companyname";
            Companyname.Size = new Size(289, 36);
            Companyname.TabIndex = 16;
            Companyname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogsDirectoryLabel
            // 
            LogsDirectoryLabel.AutoSize = true;
            LogsDirectoryLabel.Dock = DockStyle.Fill;
            LogsDirectoryLabel.Location = new Point(3, 108);
            LogsDirectoryLabel.MaximumSize = new Size(0, 39);
            LogsDirectoryLabel.MinimumSize = new Size(0, 36);
            LogsDirectoryLabel.Name = "LogsDirectoryLabel";
            LogsDirectoryLabel.Size = new Size(288, 36);
            LogsDirectoryLabel.TabIndex = 14;
            LogsDirectoryLabel.Text = "Directorio de guardado de registros";
            LogsDirectoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DBDirectoryLabel
            // 
            DBDirectoryLabel.AutoSize = true;
            DBDirectoryLabel.Dock = DockStyle.Fill;
            DBDirectoryLabel.Location = new Point(3, 72);
            DBDirectoryLabel.MaximumSize = new Size(0, 39);
            DBDirectoryLabel.MinimumSize = new Size(0, 36);
            DBDirectoryLabel.Name = "DBDirectoryLabel";
            DBDirectoryLabel.Size = new Size(288, 36);
            DBDirectoryLabel.TabIndex = 12;
            DBDirectoryLabel.Text = "Directorio de la Base de Datos";
            DBDirectoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Dock = DockStyle.Fill;
            CompanyNameLabel.Location = new Point(3, 36);
            CompanyNameLabel.MaximumSize = new Size(0, 39);
            CompanyNameLabel.MinimumSize = new Size(0, 36);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(288, 36);
            CompanyNameLabel.TabIndex = 9;
            CompanyNameLabel.Text = "Empresa";
            CompanyNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MachineQuantLabel
            // 
            MachineQuantLabel.AutoSize = true;
            MachineQuantLabel.Dock = DockStyle.Fill;
            MachineQuantLabel.Location = new Point(3, 0);
            MachineQuantLabel.MaximumSize = new Size(0, 39);
            MachineQuantLabel.MinimumSize = new Size(0, 36);
            MachineQuantLabel.Name = "MachineQuantLabel";
            MachineQuantLabel.Size = new Size(288, 36);
            MachineQuantLabel.TabIndex = 7;
            MachineQuantLabel.Text = "Cantidad de Relojes permitida";
            MachineQuantLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeveloperLabel
            // 
            DeveloperLabel.Anchor = AnchorStyles.None;
            DeveloperLabel.AutoSize = true;
            DeveloperLabel.Location = new Point(115, 288);
            DeveloperLabel.Name = "DeveloperLabel";
            DeveloperLabel.Size = new Size(63, 15);
            DeveloperLabel.TabIndex = 21;
            DeveloperLabel.Text = "Desarrollo:";
            // 
            // DeveloperName
            // 
            DeveloperName.Anchor = AnchorStyles.None;
            DeveloperName.AutoSize = true;
            DeveloperName.Location = new Point(323, 288);
            DeveloperName.Name = "DeveloperName";
            DeveloperName.Size = new Size(236, 15);
            DeveloperName.TabIndex = 22;
            DeveloperName.Text = "Agustin Luis Gullino de Informatica Integral";
            // 
            // MachineDL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 482);
            Controls.Add(MDLTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MachineDL";
            Text = "Descargador de Relojes";
            MDLTabControl.ResumeLayout(false);
            MConnectionTab.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            MUserMangTab.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            MLogsMangTab.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ConfigTab.ResumeLayout(false);
            LayoutConfigTab.ResumeLayout(false);
            LayoutConfigTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MDLTabControl;
        private TabPage MConnectionTab;
        private TabPage ConfigTab;
        private TableLayoutPanel LayoutConfigTab;
        private Label LogsDirectory;
        private Label DBDirectory;
        private Label Companyname;
        private Label LogsDirectoryLabel;
        private Label DBDirectoryLabel;
        private Label CompanyNameLabel;
        private Label MachineQuantLabel;
        private Label MachineQuant;
        private TabPage MUserMangTab;
        private TabPage MLogsMangTab;
        private Button DLLogsthisMachine;
        private CheckBox isClearAllLogs;
        private TableLayoutPanel tableLayoutPanel2;
        private Button DLUsers;
        private Button DeleteUserButton;
        private Button NewUserButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Label DeveloperLabel;
        private Label DeveloperName;
        private TableLayoutPanel tableLayoutPanel1;
        private Button DLLogsAllMachines;
        private Label RelojLabel;
        private Button ConnectButton;
        private ComboBox MachineComboBox;
        private ListView UsersListview;
        private ListView LogsListview;
        private ColumnHeader IDHeader;
        private ColumnHeader NameHeader;
        private ColumnHeader PrivilegeHeader;
        private ColumnHeader IDLogsHeader;
        private ColumnHeader InOutHeader;
        private ColumnHeader DateLogHeader;
    }
}