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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ConectionBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RelojLabel = new System.Windows.Forms.Label();
            this.RelojComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConnectionCheckBox = new System.Windows.Forms.CheckBox();
            this.UsersBox = new System.Windows.Forms.GroupBox();
            this.AttendanceBox = new System.Windows.Forms.GroupBox();
            this.DLthisMachine = new System.Windows.Forms.Button();
            this.DLAllMachines = new System.Windows.Forms.Button();
            this.isClearAllLogs = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DLUsers = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.LogsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.ConectionBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.UsersBox.SuspendLayout();
            this.AttendanceBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ConectionBox
            // 
            this.ConectionBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ConectionBox, 2);
            this.ConectionBox.Controls.Add(this.flowLayoutPanel1);
            this.ConectionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConectionBox.Location = new System.Drawing.Point(3, 3);
            this.ConectionBox.Name = "ConectionBox";
            this.ConectionBox.Size = new System.Drawing.Size(794, 51);
            this.ConectionBox.TabIndex = 0;
            this.ConectionBox.TabStop = false;
            this.ConectionBox.Text = "Conexiones";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.RelojLabel);
            this.flowLayoutPanel1.Controls.Add(this.RelojComboBox);
            this.flowLayoutPanel1.Controls.Add(this.ConnectButton);
            this.flowLayoutPanel1.Controls.Add(this.ConnectionCheckBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 29);
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
            // RelojComboBox
            // 
            this.RelojComboBox.FormattingEnabled = true;
            this.RelojComboBox.Location = new System.Drawing.Point(47, 3);
            this.RelojComboBox.Name = "RelojComboBox";
            this.RelojComboBox.Size = new System.Drawing.Size(121, 23);
            this.RelojComboBox.TabIndex = 1;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(174, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Conectar";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // ConnectionCheckBox
            // 
            this.ConnectionCheckBox.AutoSize = true;
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
            this.UsersBox.Size = new System.Drawing.Size(394, 331);
            this.UsersBox.TabIndex = 1;
            this.UsersBox.TabStop = false;
            this.UsersBox.Text = "Usuarios";
            // 
            // AttendanceBox
            // 
            this.AttendanceBox.Controls.Add(this.LogsListBox);
            this.AttendanceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttendanceBox.Location = new System.Drawing.Point(403, 60);
            this.AttendanceBox.Name = "AttendanceBox";
            this.AttendanceBox.Size = new System.Drawing.Size(394, 331);
            this.AttendanceBox.TabIndex = 2;
            this.AttendanceBox.TabStop = false;
            this.AttendanceBox.Text = "Registros de Asistencia";
            // 
            // DLthisMachine
            // 
            this.DLthisMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DLthisMachine.AutoSize = true;
            this.DLthisMachine.Location = new System.Drawing.Point(108, 397);
            this.DLthisMachine.Name = "DLthisMachine";
            this.DLthisMachine.Size = new System.Drawing.Size(183, 25);
            this.DLthisMachine.TabIndex = 3;
            this.DLthisMachine.Text = "Descargar registros de este reloj";
            this.DLthisMachine.UseVisualStyleBackColor = true;
            // 
            // DLAllMachines
            // 
            this.DLAllMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DLAllMachines.AutoSize = true;
            this.DLAllMachines.Location = new System.Drawing.Point(489, 397);
            this.DLAllMachines.Name = "DLAllMachines";
            this.DLAllMachines.Size = new System.Drawing.Size(221, 25);
            this.DLAllMachines.TabIndex = 4;
            this.DLAllMachines.Text = "Descargar registros de todos los relojes";
            this.DLAllMachines.UseVisualStyleBackColor = true;
            // 
            // isClearAllLogs
            // 
            this.isClearAllLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.isClearAllLogs.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.isClearAllLogs, 2);
            this.isClearAllLogs.Location = new System.Drawing.Point(310, 428);
            this.isClearAllLogs.Name = "isClearAllLogs";
            this.isClearAllLogs.Size = new System.Drawing.Size(180, 19);
            this.isClearAllLogs.TabIndex = 5;
            this.isClearAllLogs.Text = "Limpiar registros al descargar";
            this.isClearAllLogs.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 309);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DLUsers
            // 
            this.DLUsers.AutoSize = true;
            this.DLUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DLUsers.Location = new System.Drawing.Point(3, 3);
            this.DLUsers.Name = "DLUsers";
            this.DLUsers.Size = new System.Drawing.Size(188, 30);
            this.DLUsers.TabIndex = 0;
            this.DLUsers.Text = "Descargar Usuarios";
            this.DLUsers.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.DeleteUser.AutoSize = true;
            this.DeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteUser.Location = new System.Drawing.Point(197, 3);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(188, 30);
            this.DeleteUser.TabIndex = 1;
            this.DeleteUser.Text = "Eliminar usuario seleccionado";
            this.DeleteUser.UseVisualStyleBackColor = true;
            // 
            // UsersListBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.UsersListBox, 2);
            this.UsersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 15;
            this.UsersListBox.Location = new System.Drawing.Point(3, 39);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(382, 267);
            this.UsersListBox.TabIndex = 2;
            // 
            // LogsListBox
            // 
            this.LogsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsListBox.FormattingEnabled = true;
            this.LogsListBox.ItemHeight = 15;
            this.LogsListBox.Location = new System.Drawing.Point(3, 19);
            this.LogsListBox.Name = "LogsListBox";
            this.LogsListBox.Size = new System.Drawing.Size(388, 309);
            this.LogsListBox.TabIndex = 0;
            // 
            // MachineDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MachineDL";
            this.Text = "Descargador de Relojes";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ConectionBox.ResumeLayout(false);
            this.ConectionBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.UsersBox.ResumeLayout(false);
            this.AttendanceBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox ConectionBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label RelojLabel;
        private ComboBox RelojComboBox;
        private Button ConnectButton;
        private CheckBox ConnectionCheckBox;
        private GroupBox UsersBox;
        private GroupBox AttendanceBox;
        private Button DLthisMachine;
        private Button DLAllMachines;
        private CheckBox isClearAllLogs;
        private TableLayoutPanel tableLayoutPanel2;
        private Button DLUsers;
        private Button DeleteUser;
        private ListBox UsersListBox;
        private ListBox LogsListBox;
    }
}