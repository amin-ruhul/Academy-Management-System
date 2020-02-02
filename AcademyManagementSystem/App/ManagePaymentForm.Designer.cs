namespace App
{
    partial class ManagePaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePaymentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.BackIcon = new System.Windows.Forms.PictureBox();
            this.headingLabel = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.idLabe = new System.Windows.Forms.Label();
            this.IdText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.courseTxt = new System.Windows.Forms.TextBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.totalFeeTxt = new System.Windows.Forms.TextBox();
            this.TotalFeeLabel = new System.Windows.Forms.Label();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.FullBtn = new System.Windows.Forms.Button();
            this.HafBtn = new System.Windows.Forms.Button();
            this.fullTxt = new System.Windows.Forms.TextBox();
            this.hafTxt = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.LogoutLabel);
            this.panel1.Controls.Add(this.BackIcon);
            this.panel1.Controls.Add(this.headingLabel);
            this.panel1.Controls.Add(this.ExitIcon);
            this.panel1.Controls.Add(this.LogoutIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 73);
            this.panel1.TabIndex = 4;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.LogoutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LogoutLabel.Location = new System.Drawing.Point(902, 26);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(74, 31);
            this.LogoutLabel.TabIndex = 5;
            this.LogoutLabel.Text = "Logout";
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
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.headingLabel.Location = new System.Drawing.Point(430, 12);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(174, 31);
            this.headingLabel.TabIndex = 3;
            this.headingLabel.Text = "Manage Payment";
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
            // idLabe
            // 
            this.idLabe.AutoSize = true;
            this.idLabe.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabe.Location = new System.Drawing.Point(24, 106);
            this.idLabe.Name = "idLabe";
            this.idLabe.Size = new System.Drawing.Size(34, 30);
            this.idLabe.TabIndex = 5;
            this.idLabe.Text = "ID";
            // 
            // IdText
            // 
            this.IdText.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdText.Location = new System.Drawing.Point(113, 106);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(192, 37);
            this.IdText.TabIndex = 6;
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(113, 248);
            this.emailText.Name = "emailText";
            this.emailText.ReadOnly = true;
            this.emailText.Size = new System.Drawing.Size(319, 37);
            this.emailText.TabIndex = 8;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.Location = new System.Drawing.Point(24, 251);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(64, 30);
            this.Emaillabel.TabIndex = 7;
            this.Emaillabel.Text = "Email";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(113, 179);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.ReadOnly = true;
            this.nameTxt.Size = new System.Drawing.Size(319, 37);
            this.nameTxt.TabIndex = 10;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(24, 179);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(71, 30);
            this.namelabel.TabIndex = 9;
            this.namelabel.Text = "Name";
            // 
            // courseTxt
            // 
            this.courseTxt.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTxt.Location = new System.Drawing.Point(113, 306);
            this.courseTxt.Multiline = true;
            this.courseTxt.Name = "courseTxt";
            this.courseTxt.ReadOnly = true;
            this.courseTxt.Size = new System.Drawing.Size(319, 142);
            this.courseTxt.TabIndex = 12;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(12, 306);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(81, 30);
            this.courseLabel.TabIndex = 11;
            this.courseLabel.Text = "Course";
            // 
            // totalFeeTxt
            // 
            this.totalFeeTxt.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeeTxt.Location = new System.Drawing.Point(113, 468);
            this.totalFeeTxt.Name = "totalFeeTxt";
            this.totalFeeTxt.ReadOnly = true;
            this.totalFeeTxt.Size = new System.Drawing.Size(319, 37);
            this.totalFeeTxt.TabIndex = 16;
            // 
            // TotalFeeLabel
            // 
            this.TotalFeeLabel.AutoSize = true;
            this.TotalFeeLabel.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFeeLabel.Location = new System.Drawing.Point(7, 468);
            this.TotalFeeLabel.Name = "TotalFeeLabel";
            this.TotalFeeLabel.Size = new System.Drawing.Size(100, 30);
            this.TotalFeeLabel.TabIndex = 15;
            this.TotalFeeLabel.Text = "Total Fee";
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.EnterBtn.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.EnterBtn.Location = new System.Drawing.Point(321, 106);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(111, 47);
            this.EnterBtn.TabIndex = 17;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // FullBtn
            // 
            this.FullBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.FullBtn.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FullBtn.Location = new System.Drawing.Point(576, 313);
            this.FullBtn.Name = "FullBtn";
            this.FullBtn.Size = new System.Drawing.Size(192, 53);
            this.FullBtn.TabIndex = 18;
            this.FullBtn.Text = "Print 100%";
            this.FullBtn.UseVisualStyleBackColor = false;
            this.FullBtn.Click += new System.EventHandler(this.FullBtn_Click);
            // 
            // HafBtn
            // 
            this.HafBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.HafBtn.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HafBtn.ForeColor = System.Drawing.Color.Transparent;
            this.HafBtn.Location = new System.Drawing.Point(817, 313);
            this.HafBtn.Name = "HafBtn";
            this.HafBtn.Size = new System.Drawing.Size(192, 53);
            this.HafBtn.TabIndex = 19;
            this.HafBtn.Text = "Print 50%";
            this.HafBtn.UseVisualStyleBackColor = false;
            this.HafBtn.Click += new System.EventHandler(this.HafBtn_Click);
            // 
            // fullTxt
            // 
            this.fullTxt.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullTxt.Location = new System.Drawing.Point(576, 209);
            this.fullTxt.Multiline = true;
            this.fullTxt.Name = "fullTxt";
            this.fullTxt.ReadOnly = true;
            this.fullTxt.Size = new System.Drawing.Size(192, 76);
            this.fullTxt.TabIndex = 20;
            // 
            // hafTxt
            // 
            this.hafTxt.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hafTxt.Location = new System.Drawing.Point(817, 209);
            this.hafTxt.Multiline = true;
            this.hafTxt.Name = "hafTxt";
            this.hafTxt.ReadOnly = true;
            this.hafTxt.Size = new System.Drawing.Size(192, 76);
            this.hafTxt.TabIndex = 21;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(105)))));
            this.clearBtn.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.clearBtn.Location = new System.Drawing.Point(576, 418);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(433, 47);
            this.clearBtn.TabIndex = 22;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ManagePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(216)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.hafTxt);
            this.Controls.Add(this.fullTxt);
            this.Controls.Add(this.HafBtn);
            this.Controls.Add(this.FullBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.totalFeeTxt);
            this.Controls.Add(this.TotalFeeLabel);
            this.Controls.Add(this.courseTxt);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.idLabe);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagePaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagePaymentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogoutLabel;
        private System.Windows.Forms.PictureBox BackIcon;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.Label idLabe;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox courseTxt;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.TextBox totalFeeTxt;
        private System.Windows.Forms.Label TotalFeeLabel;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button FullBtn;
        private System.Windows.Forms.Button HafBtn;
        private System.Windows.Forms.TextBox fullTxt;
        private System.Windows.Forms.TextBox hafTxt;
        private System.Windows.Forms.Button clearBtn;
    }
}