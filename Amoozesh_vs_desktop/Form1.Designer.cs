namespace Amoozesh_vs_desktop
{
    partial class frmFirst
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirst));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewUser = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.dgvContacts_Table = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbNewUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewUser,
            this.tsbRefresh,
            this.tsbDelete,
            this.tsbEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1502, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNewUser
            // 
            this.toolStripButtonNewUser.Image = global::Amoozesh_vs_desktop.Properties.Resources.user;
            this.toolStripButtonNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewUser.Name = "toolStripButtonNewUser";
            this.toolStripButtonNewUser.Size = new System.Drawing.Size(190, 45);
            this.toolStripButtonNewUser.Text = "New User";
            this.toolStripButtonNewUser.Click += new System.EventHandler(this.toolStripButtonNewUser_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tsbRefresh.Image = global::Amoozesh_vs_desktop.Properties.Resources.reload;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(160, 45);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.ForeColor = System.Drawing.Color.Firebrick;
            this.tsbDelete.Image = global::Amoozesh_vs_desktop.Properties.Resources.icons8_remove_100;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(148, 45);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.ForeColor = System.Drawing.Color.DarkGreen;
            this.tsbEdit.Image = global::Amoozesh_vs_desktop.Properties.Resources.icons8_create_100;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(112, 45);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // dgvContacts_Table
            // 
            this.dgvContacts_Table.AllowUserToAddRows = false;
            this.dgvContacts_Table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvContacts_Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContacts_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContacts_Table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvContacts_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContacts_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name_Person,
            this.Family,
            this.Phone,
            this.Address});
            this.dgvContacts_Table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvContacts_Table.GridColor = System.Drawing.SystemColors.Control;
            this.dgvContacts_Table.Location = new System.Drawing.Point(12, 95);
            this.dgvContacts_Table.MultiSelect = false;
            this.dgvContacts_Table.Name = "dgvContacts_Table";
            this.dgvContacts_Table.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContacts_Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvContacts_Table.RowHeadersWidth = 102;
            this.dgvContacts_Table.RowTemplate.Height = 40;
            this.dgvContacts_Table.ShowCellErrors = false;
            this.dgvContacts_Table.Size = new System.Drawing.Size(1463, 522);
            this.dgvContacts_Table.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 44);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tsbNewUser
            // 
            this.tsbNewUser.AutoSize = false;
            this.tsbNewUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewUser.Image = global::Amoozesh_vs_desktop.Properties.Resources.user;
            this.tsbNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewUser.Name = "tsbNewUser";
            this.tsbNewUser.Size = new System.Drawing.Size(58, 55);
            this.tsbNewUser.Text = "toolStripButton2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Amoozesh_vs_desktop.Properties.Resources.user;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(211, 45);
            this.toolStripButton2.Text = "شخص جدید";
            this.toolStripButton2.ToolTipText = "اضافه کردن شخص جدید\r\n";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(58, 45);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.BackgroundImage = global::Amoozesh_vs_desktop.Properties.Resources.user;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(58, 55);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbSearch.Location = new System.Drawing.Point(12, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(256, 55);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(275, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "جستجو : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("French Script MT", 15.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(216, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtering ...";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "کد";
            this.ID.MinimumWidth = 12;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Name_Person
            // 
            this.Name_Person.DataPropertyName = "Name";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name_Person.DefaultCellStyle = dataGridViewCellStyle3;
            this.Name_Person.HeaderText = "اسم";
            this.Name_Person.MaxInputLength = 200;
            this.Name_Person.MinimumWidth = 12;
            this.Name_Person.Name = "Name_Person";
            this.Name_Person.ReadOnly = true;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Family.DefaultCellStyle = dataGridViewCellStyle4;
            this.Family.HeaderText = "فامیل";
            this.Family.MaxInputLength = 200;
            this.Family.MinimumWidth = 12;
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Phone.DefaultCellStyle = dataGridViewCellStyle5;
            this.Phone.HeaderText = "تلفن";
            this.Phone.MaxInputLength = 13;
            this.Phone.MinimumWidth = 12;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Address.DefaultCellStyle = dataGridViewCellStyle6;
            this.Address.HeaderText = "آدرس";
            this.Address.MinimumWidth = 12;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // frmFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 52F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amoozesh_vs_desktop.Properties.Resources.wooden_table_wall_shadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1502, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvContacts_Table);
            this.Font = new System.Drawing.Font("B Nazanin", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmFirst";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفترچه یادداشت";
            this.Load += new System.EventHandler(this.frmFirst_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvContacts_Table;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbNewUser;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewUser;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}

