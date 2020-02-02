namespace App
{
    partial class ManageEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployeeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BackIcon = new System.Windows.Forms.PictureBox();
            this.headingL = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DesiBox = new System.Windows.Forms.ComboBox();
            this.EEmailText = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.InsertEmployeeBtn = new System.Windows.Forms.Button();
            this.EIdText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ENametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ESalarytext = new System.Windows.Forms.TextBox();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.headingL.Size = new System.Drawing.Size(178, 31);
            this.headingL.TabIndex = 3;
            this.headingL.Text = "Manage Employee";
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(216)))), ((int)(((byte)(234)))));
            this.panel2.Controls.Add(this.ClearBtn);
            this.panel2.Controls.Add(this.DesiBox);
            this.panel2.Controls.Add(this.EEmailText);
            this.panel2.Controls.Add(this.EmailLabel);
            this.panel2.Controls.Add(this.UpdateBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.InsertEmployeeBtn);
            this.panel2.Controls.Add(this.EIdText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.EName);
            this.panel2.Controls.Add(this.genderBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ENametext);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ESalarytext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 471);
            this.panel2.TabIndex = 14;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ClearBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(321, 413);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(141, 46);
            this.ClearBtn.TabIndex = 19;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DesiBox
            // 
            this.DesiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiBox.FormattingEnabled = true;
            this.DesiBox.Items.AddRange(new object[] {
            "Trainer",
            "Admin",
            "Manager"});
            this.DesiBox.Location = new System.Drawing.Point(198, 280);
            this.DesiBox.Name = "DesiBox";
            this.DesiBox.Size = new System.Drawing.Size(205, 34);
            this.DesiBox.TabIndex = 18;
            this.DesiBox.Text = "Select Designation";
            // 
            // EEmailText
            // 
            this.EEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EEmailText.Location = new System.Drawing.Point(198, 165);
            this.EEmailText.Name = "EEmailText";
            this.EEmailText.Size = new System.Drawing.Size(205, 32);
            this.EEmailText.TabIndex = 17;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(42, 164);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(78, 30);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(174, 353);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(141, 46);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Designation";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(321, 353);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(141, 46);
            this.DeleteBtn.TabIndex = 14;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // InsertEmployeeBtn
            // 
            this.InsertEmployeeBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.InsertEmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.InsertEmployeeBtn.Location = new System.Drawing.Point(14, 353);
            this.InsertEmployeeBtn.Name = "InsertEmployeeBtn";
            this.InsertEmployeeBtn.Size = new System.Drawing.Size(141, 46);
            this.InsertEmployeeBtn.TabIndex = 13;
            this.InsertEmployeeBtn.Text = "INSERT";
            this.InsertEmployeeBtn.UseVisualStyleBackColor = false;
            this.InsertEmployeeBtn.Click += new System.EventHandler(this.InsertEmployeeBtn_Click);
            // 
            // EIdText
            // 
            this.EIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EIdText.Location = new System.Drawing.Point(198, 16);
            this.EIdText.Name = "EIdText";
            this.EIdText.Size = new System.Drawing.Size(205, 32);
            this.EIdText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gender";
            // 
            // EName
            // 
            this.EName.AutoSize = true;
            this.EName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EName.Location = new System.Drawing.Point(46, 15);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(44, 30);
            this.EName.TabIndex = 3;
            this.EName.Text = "ID:";
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Femal"});
            this.genderBox.Location = new System.Drawing.Point(198, 221);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(205, 34);
            this.genderBox.TabIndex = 11;
            this.genderBox.Text = "Select Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // ENametext
            // 
            this.ENametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENametext.Location = new System.Drawing.Point(198, 65);
            this.ENametext.Name = "ENametext";
            this.ENametext.Size = new System.Drawing.Size(205, 32);
            this.ENametext.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salary";
            // 
            // ESalarytext
            // 
            this.ESalarytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESalarytext.Location = new System.Drawing.Point(198, 114);
            this.ESalarytext.Name = "ESalarytext";
            this.ESalarytext.Size = new System.Drawing.Size(205, 32);
            this.ESalarytext.TabIndex = 8;
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.Location = new System.Drawing.Point(613, 79);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(381, 30);
            this.SearchtextBox.TabIndex = 21;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.Search);
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Searchlabel.Location = new System.Drawing.Point(532, 80);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(75, 31);
            this.Searchlabel.TabIndex = 20;
            this.Searchlabel.Text = "Serach";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(501, 126);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(565, 406);
            this.dataGridView.TabIndex = 19;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(153)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEmployeeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.ManageEmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox BackIcon;
        private System.Windows.Forms.Label headingL;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.PictureBox LogoutIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ComboBox DesiBox;
        private System.Windows.Forms.TextBox EEmailText;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button InsertEmployeeBtn;
        private System.Windows.Forms.TextBox EIdText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EName;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ENametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ESalarytext;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}