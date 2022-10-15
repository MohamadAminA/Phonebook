namespace Amoozesh_vs_desktop
{
    partial class frmNewEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewEditPerson));
            this.btnSabt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSabt
            // 
            this.btnSabt.Font = new System.Drawing.Font("B Nazanin", 19.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSabt.Location = new System.Drawing.Point(423, 308);
            this.btnSabt.Name = "btnSabt";
            this.btnSabt.Size = new System.Drawing.Size(212, 100);
            this.btnSabt.TabIndex = 0;
            this.btnSabt.Text = "ثبت";
            this.btnSabt.UseVisualStyleBackColor = true;
            this.btnSabt.Click += new System.EventHandler(this.btnSabt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(981, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام : ";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("B Nazanin", 14.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbName.Location = new System.Drawing.Point(638, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(318, 86);
            this.tbName.TabIndex = 2;
            // 
            // tbFamily
            // 
            this.tbFamily.Font = new System.Drawing.Font("B Nazanin", 14.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbFamily.Location = new System.Drawing.Point(24, 23);
            this.tbFamily.Name = "tbFamily";
            this.tbFamily.Size = new System.Drawing.Size(318, 86);
            this.tbFamily.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(367, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 79);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی : ";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("B Nazanin", 14.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbPhone.Location = new System.Drawing.Point(638, 146);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(318, 86);
            this.tbPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(981, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 79);
            this.label3.TabIndex = 5;
            this.label3.Text = "تلفن : ";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Font = new System.Drawing.Font("B Nazanin", 14.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbAddress.Location = new System.Drawing.Point(24, 149);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAddress.Size = new System.Drawing.Size(318, 140);
            this.tbAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(367, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 79);
            this.label4.TabIndex = 7;
            this.label4.Text = "آدرس : ";
            // 
            // frmNewEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 52F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amoozesh_vs_desktop.Properties.Resources.White_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 460);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFamily);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSabt);
            this.Font = new System.Drawing.Font("B Nazanin", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(8000, 1000);
            this.MinimizeBox = false;
            this.Name = "frmNewEditPerson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmNewEditPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSabt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
    }
}