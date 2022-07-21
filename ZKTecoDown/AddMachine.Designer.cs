namespace ZKTecoDown
{
    partial class AddMachine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.IPAddressListview = new System.Windows.Forms.ListView();
            this.DescriptHeader = new System.Windows.Forms.ColumnHeader();
            this.IPHeader = new System.Windows.Forms.ColumnHeader();
            this.PortHeader = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortNumericBox = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.IPAddressListview, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 39);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(236, 25);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Añadir";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(245, 39);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(237, 25);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Quitar";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(488, 39);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(243, 25);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Guardar y salir";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // IPAddressListview
            // 
            this.IPAddressListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DescriptHeader,
            this.IPHeader,
            this.PortHeader});
            this.tableLayoutPanel1.SetColumnSpan(this.IPAddressListview, 3);
            this.IPAddressListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IPAddressListview.FullRowSelect = true;
            this.IPAddressListview.GridLines = true;
            this.IPAddressListview.Location = new System.Drawing.Point(3, 70);
            this.IPAddressListview.Name = "IPAddressListview";
            this.IPAddressListview.Size = new System.Drawing.Size(728, 188);
            this.IPAddressListview.TabIndex = 0;
            this.IPAddressListview.UseCompatibleStateImageBehavior = false;
            this.IPAddressListview.View = System.Windows.Forms.View.Details;
            this.IPAddressListview.SizeChanged += new System.EventHandler(this.IPAddressListview_SizeChanged);
            // 
            // DescriptHeader
            // 
            this.DescriptHeader.Text = "Descripcion";
            this.DescriptHeader.Width = 291;
            // 
            // IPHeader
            // 
            this.IPHeader.Text = "IP";
            this.IPHeader.Width = 291;
            // 
            // PortHeader
            // 
            this.PortHeader.Text = "Puerto";
            this.PortHeader.Width = 145;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.NameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(236, 30);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Location = new System.Drawing.Point(78, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(155, 23);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.MaximumSize = new System.Drawing.Size(0, 29);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 29);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Descripcion";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.IPTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.IPLabel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(245, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(237, 30);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IPTextBox.Location = new System.Drawing.Point(26, 3);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(208, 23);
            this.IPTextBox.TabIndex = 2;
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IPLabel.Location = new System.Drawing.Point(3, 0);
            this.IPLabel.MaximumSize = new System.Drawing.Size(0, 29);
            this.IPLabel.MinimumSize = new System.Drawing.Size(0, 29);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(17, 29);
            this.IPLabel.TabIndex = 3;
            this.IPLabel.Text = "IP";
            this.IPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.PortLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PortNumericBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(488, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(243, 30);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortLabel.Location = new System.Drawing.Point(3, 0);
            this.PortLabel.MaximumSize = new System.Drawing.Size(0, 29);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(42, 29);
            this.PortLabel.TabIndex = 4;
            this.PortLabel.Text = "Puerto";
            this.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortNumericBox
            // 
            this.PortNumericBox.AutoSize = true;
            this.PortNumericBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortNumericBox.Location = new System.Drawing.Point(51, 3);
            this.PortNumericBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PortNumericBox.Name = "PortNumericBox";
            this.PortNumericBox.Size = new System.Drawing.Size(189, 23);
            this.PortNumericBox.TabIndex = 5;
            // 
            // AddMachine
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Añadir Relojes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumericBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button AddButton;
        private Button DeleteButton;
        private Button SaveButton;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox NameTextBox;
        private Label NameLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox IPTextBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label IPLabel;
        private Label PortLabel;
        private NumericUpDown PortNumericBox;
        private ColumnHeader DescriptHeader;
        private ColumnHeader IPHeader;
        private ColumnHeader PortHeader;
        public ListView IPAddressListview;
    }
}