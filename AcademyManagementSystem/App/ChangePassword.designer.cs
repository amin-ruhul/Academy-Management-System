namespace App
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BackIcon = new System.Windows.Forms.PictureBox();
            this.headingL = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.CPcheckBox = new System.Windows.Forms.CheckBox();
            this.EntBtn = new System.Windows.Forms.Button();
            this.conPassBox = new System.Windows.Forms.TextBox();
            this.conPlabel = new System.Windows.Forms.Label();
            this.newPassBox = new System.Windows.Forms.TextBox();
            this.newPlabel = new System.Windows.Forms.Label();
            this.opEnterBtn = new System.Windows.Forms.Button();
            this.oldPassBox = new System.Windows.Forms.TextBox();
            this.oPlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BackIcon);
            this.panel1.Controls.Add(this.headingL);
            this.panel1.Controls.Add(this.ExitIcon);
            this.panel1.Controls.Add(this.LogoutIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 73);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(902, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 5;
            // 
            // BackIcon
            // 
            this.BackIcon.Image = ((System.Drawing.Image)(resources.GetObject("BackIcon.Image")));
            this.BackIcon.Location = new System.Drawing.Point(12, 12);
            this.BackIcon.Name = "BackIcon";
            this.BackIcon.Size = new System.Drawing.Size(44, 45);
            this.BackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackIcon.TabIndex = 4;
            this.BackIcon.TabStop = false;
            this.BackIcon.Click += new System.EventHandler(this.BackIcon_Click);
            // 
            // headingL
            // 
            this.headingL.AutoSize = true;
            this.headingL.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.headingL.Location = new System.Drawing.Point(430, 12);
            this.headingL.Name = "headingL";
            this.headingL.Size = new System.Drawing.Size(174, 31);
            this.headingL.TabIndex = 3;
            this.headingL.Text = "Change Password";
            // 
            // ExitIcon
            // 
            this.ExitIcon.Image = ((System.Drawing.Image)(resources.GetObject("ExitIcon.Image")));
            this.ExitIcon.Location = new System.Drawing.Point(1022, 12);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(44, 45);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitIcon.TabIndex = 2;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // LogoutIcon
            // 
            this.LogoutIcon.Image = ((System.Drawing.Image)(resources.GetObject("LogoutIcon.Image")));
            this.LogoutIcon.Location = new System.Drawing.Point(847, 12);
            this.LogoutIcon.Name = "LogoutIcon";
            this.LogoutIcon.Size = new System.Drawing.Size(49, 45);
            this.LogoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoutIcon.TabIndex = 1;
            this.LogoutIcon.TabStop = false;
            this.LogoutIcon.Click += new System.EventHandler(this.LogoutIcon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.panel2.Controls.Add(this.checkBox);
            this.panel2.Controls.Add(this.CPcheckBox);
            this.panel2.Controls.Add(this.EntBtn);
            this.panel2.Controls.Add(this.conPassBox);
            this.panel2.Controls.Add(this.conPlabel);
            this.panel2.Controls.Add(this.newPassBox);
            this.panel2.Controls.Add(this.newPlabel);
            this.panel2.Controls.Add(this.opEnterBtn);
            this.panel2.Controls.Add(this.oldPassBox);
            this.panel2.Controls.Add(this.oPlabel);
            this.panel2.Location = new System.Drawing.Point(265, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 453);
            this.panel2.TabIndex = 5;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox.Location = new System.Drawing.Point(457, 239);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(68, 21);
            this.checkBox.TabIndex = 9;
            this.checkBox.Text = "show";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // CPcheckBox
            // 
            this.CPcheckBox.AutoSize = true;
            this.CPcheckBox.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPcheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CPcheckBox.Location = new System.Drawing.Point(457, 64);
            this.CPcheckBox.Name = "CPcheckBox";
            this.CPcheckBox.Size = new System.Drawing.Size(68, 21);
            this.CPcheckBox.TabIndex = 8;
            this.CPcheckBox.Text = "show";
            this.CPcheckBox.UseVisualStyleBackColor = true;
            this.CPcheckBox.CheckedChanged += new System.EventHandler(this.CPcheckBox_CheckedChanged);
            // 
            // EntBtn
            // 
            this.EntBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.EntBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntBtn.ForeColor = System.Drawing.Color.White;
            this.EntBtn.Location = new System.Drawing.Point(236, 331);
            this.EntBtn.Name = "EntBtn";
            this.EntBtn.Size = new System.Drawing.Size(202, 38);
            this.EntBtn.TabIndex = 7;
            this.EntBtn.Text = "Enter";
            this.EntBtn.UseVisualStyleBackColor = false;
            this.EntBtn.Click += new System.EventHandler(this.EntBtn_Click);
            // 
            // conPassBox
            // 
            this.conPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPassBox.Location = new System.Drawing.Point(236, 269);
            this.conPassBox.Name = "conPassBox";
            this.conPassBox.Size = new System.Drawing.Size(202, 30);
            this.conPassBox.TabIndex = 6;
            this.conPassBox.UseSystemPasswordChar = true;
            // 
            // conPlabel
            // 
            this.conPlabel.AutoSize = true;
            this.conPlabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPlabel.ForeColor = System.Drawing.Color.White;
            this.conPlabel.Location = new System.Drawing.Point(16, 271);
            this.conPlabel.Name = "conPlabel";
            this.conPlabel.Size = new System.Drawing.Size(205, 25);
            this.conPlabel.TabIndex = 5;
            this.conPlabel.Text = "Confirm Password";
            // 
            // newPassBox
            // 
            this.newPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassBox.Location = new System.Drawing.Point(236, 202);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.Size = new System.Drawing.Size(202, 30);
            this.newPassBox.TabIndex = 4;
            this.newPassBox.UseSystemPasswordChar = true;
            // 
            // newPlabel
            // 
            this.newPlabel.AutoSize = true;
            this.newPlabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlabel.ForeColor = System.Drawing.Color.White;
            this.newPlabel.Location = new System.Drawing.Point(61, 202);
            this.newPlabel.Name = "newPlabel";
            this.newPlabel.Size = new System.Drawing.Size(170, 25);
            this.newPlabel.TabIndex = 3;
            this.newPlabel.Text = "New Password";
            // 
            // opEnterBtn
            // 
            this.opEnterBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.opEnterBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opEnterBtn.ForeColor = System.Drawing.Color.White;
            this.opEnterBtn.Location = new System.Drawing.Point(262, 113);
            this.opEnterBtn.Name = "opEnterBtn";
            this.opEnterBtn.Size = new System.Drawing.Size(189, 42);
            this.opEnterBtn.TabIndex = 2;
            this.opEnterBtn.Text = "Enter";
            this.opEnterBtn.UseVisualStyleBackColor = false;
            this.opEnterBtn.Click += new System.EventHandler(this.opEnterBtn_Click);
            // 
            // oldPassBox
            // 
            this.oldPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassBox.Location = new System.Drawing.Point(249, 60);
            this.oldPassBox.Name = "oldPassBox";
            this.oldPassBox.Size = new System.Drawing.Size(202, 30);
            this.oldPassBox.TabIndex = 1;
            this.oldPassBox.UseSystemPasswordChar = true;
            // 
            // oPlabel
            // 
            this.oPlabel.AutoSize = true;
            this.oPlabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oPlabel.ForeColor = System.Drawing.Color.White;
            this.oPlabel.Location = new System.Drawing.Point(31, 60);
            this.oPlabel.Name = "oPlabel";
            this.oPlabel.Size = new System.Drawing.Size(200, 25);
            this.oPlabel.TabIndex = 0;
            this.oPlabel.Text = "Current Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox BackIcon;
        private System.Windows.Forms.Label headingL;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.CheckBox CPcheckBox;
        private System.Windows.Forms.Button EntBtn;
        private System.Windows.Forms.TextBox conPassBox;
        private System.Windows.Forms.Label conPlabel;
        private System.Windows.Forms.TextBox newPassBox;
        private System.Windows.Forms.Label newPlabel;
        private System.Windows.Forms.Button opEnterBtn;
        private System.Windows.Forms.TextBox oldPassBox;
        private System.Windows.Forms.Label oPlabel;
    }
}