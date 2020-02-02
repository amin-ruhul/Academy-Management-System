namespace App
{
    partial class ForgetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.headingL = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.EmailgroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.GetBtn = new System.Windows.Forms.Button();
            this.CodegroupBox = new System.Windows.Forms.GroupBox();
            this.TextMBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.PassgroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.conPassBox = new System.Windows.Forms.TextBox();
            this.newPassBox = new System.Windows.Forms.TextBox();
            this.EBtn = new System.Windows.Forms.Button();
            this.UsergroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userIdtextBox = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.BackIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            this.EmailgroupBox.SuspendLayout();
            this.CodegroupBox.SuspendLayout();
            this.PassgroupBox.SuspendLayout();
            this.UsergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.BackIcon);
            this.panel1.Controls.Add(this.headingL);
            this.panel1.Controls.Add(this.ExitIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 73);
            this.panel1.TabIndex = 2;
            // 
            // headingL
            // 
            this.headingL.AutoSize = true;
            this.headingL.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.headingL.Location = new System.Drawing.Point(452, 21);
            this.headingL.Name = "headingL";
            this.headingL.Size = new System.Drawing.Size(165, 31);
            this.headingL.TabIndex = 4;
            this.headingL.Text = "Forget Password";
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
            // EmailgroupBox
            // 
            this.EmailgroupBox.Controls.Add(this.label3);
            this.EmailgroupBox.Controls.Add(this.Mail);
            this.EmailgroupBox.Controls.Add(this.GetBtn);
            this.EmailgroupBox.Location = new System.Drawing.Point(28, 264);
            this.EmailgroupBox.Name = "EmailgroupBox";
            this.EmailgroupBox.Size = new System.Drawing.Size(490, 180);
            this.EmailgroupBox.TabIndex = 18;
            this.EmailgroupBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = " Your Email:";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Mail.Location = new System.Drawing.Point(143, 53);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(172, 23);
            this.Mail.TabIndex = 5;
            this.Mail.Text = "abc@gmail.com";
            // 
            // GetBtn
            // 
            this.GetBtn.BackColor = System.Drawing.Color.Brown;
            this.GetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetBtn.ForeColor = System.Drawing.Color.Transparent;
            this.GetBtn.Location = new System.Drawing.Point(131, 98);
            this.GetBtn.Name = "GetBtn";
            this.GetBtn.Size = new System.Drawing.Size(161, 53);
            this.GetBtn.TabIndex = 7;
            this.GetBtn.Text = "Get Code";
            this.GetBtn.UseVisualStyleBackColor = false;
            this.GetBtn.Click += new System.EventHandler(this.GetBtn_Click);
            // 
            // CodegroupBox
            // 
            this.CodegroupBox.Controls.Add(this.TextMBtn);
            this.CodegroupBox.Controls.Add(this.label4);
            this.CodegroupBox.Controls.Add(this.codetxt);
            this.CodegroupBox.Location = new System.Drawing.Point(637, 92);
            this.CodegroupBox.Name = "CodegroupBox";
            this.CodegroupBox.Size = new System.Drawing.Size(266, 167);
            this.CodegroupBox.TabIndex = 19;
            this.CodegroupBox.TabStop = false;
            // 
            // TextMBtn
            // 
            this.TextMBtn.BackColor = System.Drawing.Color.Brown;
            this.TextMBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMBtn.ForeColor = System.Drawing.Color.Transparent;
            this.TextMBtn.Location = new System.Drawing.Point(34, 103);
            this.TextMBtn.Name = "TextMBtn";
            this.TextMBtn.Size = new System.Drawing.Size(200, 51);
            this.TextMBtn.TabIndex = 10;
            this.TextMBtn.Text = "Enter";
            this.TextMBtn.UseVisualStyleBackColor = false;
            this.TextMBtn.Click += new System.EventHandler(this.TextMBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(30, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = " Enter Code";
            // 
            // codetxt
            // 
            this.codetxt.Location = new System.Drawing.Point(33, 62);
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(201, 26);
            this.codetxt.TabIndex = 9;
            // 
            // PassgroupBox
            // 
            this.PassgroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.PassgroupBox.Controls.Add(this.checkBox);
            this.PassgroupBox.Controls.Add(this.label5);
            this.PassgroupBox.Controls.Add(this.label6);
            this.PassgroupBox.Controls.Add(this.conPassBox);
            this.PassgroupBox.Controls.Add(this.newPassBox);
            this.PassgroupBox.Controls.Add(this.EBtn);
            this.PassgroupBox.Location = new System.Drawing.Point(376, 92);
            this.PassgroupBox.Name = "PassgroupBox";
            this.PassgroupBox.Size = new System.Drawing.Size(551, 400);
            this.PassgroupBox.TabIndex = 20;
            this.PassgroupBox.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(394, 158);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(75, 24);
            this.checkBox.TabIndex = 16;
            this.checkBox.Text = "Show";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(157, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "New Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(157, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Confirm Password";
            // 
            // conPassBox
            // 
            this.conPassBox.Location = new System.Drawing.Point(161, 196);
            this.conPassBox.Name = "conPassBox";
            this.conPassBox.Size = new System.Drawing.Size(201, 26);
            this.conPassBox.TabIndex = 13;
            this.conPassBox.UseSystemPasswordChar = true;
            // 
            // newPassBox
            // 
            this.newPassBox.Location = new System.Drawing.Point(161, 119);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.Size = new System.Drawing.Size(201, 26);
            this.newPassBox.TabIndex = 14;
            this.newPassBox.UseSystemPasswordChar = true;
            // 
            // EBtn
            // 
            this.EBtn.BackColor = System.Drawing.Color.Brown;
            this.EBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EBtn.ForeColor = System.Drawing.Color.Transparent;
            this.EBtn.Location = new System.Drawing.Point(162, 242);
            this.EBtn.Name = "EBtn";
            this.EBtn.Size = new System.Drawing.Size(201, 41);
            this.EBtn.TabIndex = 15;
            this.EBtn.Text = "Enter";
            this.EBtn.UseVisualStyleBackColor = false;
            this.EBtn.Click += new System.EventHandler(this.Enter_Click);
            // 
            // UsergroupBox
            // 
            this.UsergroupBox.Controls.Add(this.label1);
            this.UsergroupBox.Controls.Add(this.userIdtextBox);
            this.UsergroupBox.Controls.Add(this.EnterBtn);
            this.UsergroupBox.Location = new System.Drawing.Point(47, 92);
            this.UsergroupBox.Name = "UsergroupBox";
            this.UsergroupBox.Size = new System.Drawing.Size(306, 166);
            this.UsergroupBox.TabIndex = 17;
            this.UsergroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = " Enter User Id";
            // 
            // userIdtextBox
            // 
            this.userIdtextBox.Location = new System.Drawing.Point(50, 63);
            this.userIdtextBox.Name = "userIdtextBox";
            this.userIdtextBox.Size = new System.Drawing.Size(201, 26);
            this.userIdtextBox.TabIndex = 3;
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.Brown;
            this.EnterBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBtn.ForeColor = System.Drawing.Color.Transparent;
            this.EnterBtn.Location = new System.Drawing.Point(49, 110);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(201, 50);
            this.EnterBtn.TabIndex = 4;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // BackIcon
            // 
            this.BackIcon.Image = ((System.Drawing.Image)(resources.GetObject("BackIcon.Image")));
            this.BackIcon.Location = new System.Drawing.Point(12, 12);
            this.BackIcon.Name = "BackIcon";
            this.BackIcon.Size = new System.Drawing.Size(44, 45);
            this.BackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackIcon.TabIndex = 5;
            this.BackIcon.TabStop = false;
            this.BackIcon.Click += new System.EventHandler(this.BackIcon_Click);
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.UsergroupBox);
            this.Controls.Add(this.PassgroupBox);
            this.Controls.Add(this.CodegroupBox);
            this.Controls.Add(this.EmailgroupBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.ForgetPasswordForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            this.EmailgroupBox.ResumeLayout(false);
            this.EmailgroupBox.PerformLayout();
            this.CodegroupBox.ResumeLayout(false);
            this.CodegroupBox.PerformLayout();
            this.PassgroupBox.ResumeLayout(false);
            this.PassgroupBox.PerformLayout();
            this.UsergroupBox.ResumeLayout(false);
            this.UsergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headingL;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.GroupBox EmailgroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Button GetBtn;
        private System.Windows.Forms.GroupBox CodegroupBox;
        private System.Windows.Forms.Button TextMBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.GroupBox PassgroupBox;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox conPassBox;
        private System.Windows.Forms.TextBox newPassBox;
        private System.Windows.Forms.Button EBtn;
        private System.Windows.Forms.GroupBox UsergroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userIdtextBox;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.PictureBox BackIcon;
    }
}