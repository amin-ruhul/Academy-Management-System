namespace App
{
    partial class ManageStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudentForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BackIcon = new System.Windows.Forms.PictureBox();
            this.headingL = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FeesTxt = new System.Windows.Forms.TextBox();
            this.totalFeeBox = new System.Windows.Forms.TextBox();
            this.feeBox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CourseCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.CourseTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BackIcon);
            this.panel2.Controls.Add(this.headingL);
            this.panel2.Controls.Add(this.ExitIcon);
            this.panel2.Controls.Add(this.LogoutIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 73);
            this.panel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(902, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Logout";
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
            this.headingL.Size = new System.Drawing.Size(163, 31);
            this.headingL.TabIndex = 3;
            this.headingL.Text = "Manage Student";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.CourseTextBox);
            this.panel1.Controls.Add(this.FeesTxt);
            this.panel1.Controls.Add(this.totalFeeBox);
            this.panel1.Controls.Add(this.feeBox);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.InsertBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.IdTextBox);
            this.panel1.Controls.Add(this.CourseCombo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 471);
            this.panel1.TabIndex = 11;
            // 
            // FeesTxt
            // 
            this.FeesTxt.Location = new System.Drawing.Point(360, 243);
            this.FeesTxt.Name = "FeesTxt";
            this.FeesTxt.ReadOnly = true;
            this.FeesTxt.Size = new System.Drawing.Size(70, 26);
            this.FeesTxt.TabIndex = 33;
            // 
            // totalFeeBox
            // 
            this.totalFeeBox.Location = new System.Drawing.Point(360, 282);
            this.totalFeeBox.Name = "totalFeeBox";
            this.totalFeeBox.ReadOnly = true;
            this.totalFeeBox.Size = new System.Drawing.Size(70, 26);
            this.totalFeeBox.TabIndex = 32;
            // 
            // feeBox
            // 
            this.feeBox.Location = new System.Drawing.Point(360, 211);
            this.feeBox.Name = "feeBox";
            this.feeBox.ReadOnly = true;
            this.feeBox.Size = new System.Drawing.Size(70, 26);
            this.feeBox.TabIndex = 31;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.ClearBtn.Location = new System.Drawing.Point(306, 398);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(129, 43);
            this.ClearBtn.TabIndex = 26;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(59)))), ((int)(((byte)(94)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.DeleteBtn.Location = new System.Drawing.Point(305, 337);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(129, 43);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UpdateBtn.Location = new System.Drawing.Point(170, 337);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(129, 43);
            this.UpdateBtn.TabIndex = 22;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(91)))), ((int)(((byte)(123)))));
            this.InsertBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.InsertBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InsertBtn.Location = new System.Drawing.Point(35, 337);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(129, 43);
            this.InsertBtn.TabIndex = 24;
            this.InsertBtn.Text = "INSERT";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.label6.Location = new System.Drawing.Point(26, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Course";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(360, 169);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 35);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(34, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(120, 66);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(315, 34);
            this.NameTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(120, 118);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(315, 34);
            this.EmailTextBox.TabIndex = 19;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.idLabel.Location = new System.Drawing.Point(34, 21);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(34, 25);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(120, 18);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(315, 34);
            this.IdTextBox.TabIndex = 17;
            // 
            // CourseCombo
            // 
            this.CourseCombo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.CourseCombo.FormattingEnabled = true;
            this.CourseCombo.Location = new System.Drawing.Point(120, 169);
            this.CourseCombo.Name = "CourseCombo";
            this.CourseCombo.Size = new System.Drawing.Size(234, 33);
            this.CourseCombo.TabIndex = 13;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(505, 139);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(561, 393);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.search.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(516, 99);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(65, 24);
            this.search.TabIndex = 13;
            this.search.Text = "Search";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(604, 95);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(438, 30);
            this.SearchBox.TabIndex = 14;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.CourseTextBox.Location = new System.Drawing.Point(120, 212);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.ReadOnly = true;
            this.CourseTextBox.Size = new System.Drawing.Size(234, 104);
            this.CourseTextBox.TabIndex = 34;
            this.CourseTextBox.Text = "";
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox BackIcon;
        private System.Windows.Forms.Label headingL;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.ComboBox CourseCombo;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox feeBox;
        private System.Windows.Forms.TextBox totalFeeBox;
        private System.Windows.Forms.TextBox FeesTxt;
        private System.Windows.Forms.RichTextBox CourseTextBox;
    }
}