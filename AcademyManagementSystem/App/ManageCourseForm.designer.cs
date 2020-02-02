namespace App
{
    partial class ManageCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCourseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BackIcon = new System.Windows.Forms.PictureBox();
            this.headingL = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.LogoutIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.CourseIdText = new System.Windows.Forms.TextBox();
            this.CidLabel = new System.Windows.Forms.Label();
            this.CNameLabel = new System.Windows.Forms.Label();
            this.CourseNametext = new System.Windows.Forms.TextBox();
            this.CFeeLabel = new System.Windows.Forms.Label();
            this.CourseFeeText = new System.Windows.Forms.TextBox();
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
            this.panel1.TabIndex = 4;
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
            this.headingL.Size = new System.Drawing.Size(151, 31);
            this.headingL.TabIndex = 3;
            this.headingL.Text = "Manage Course";
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(222)))));
            this.panel2.Controls.Add(this.ClearBtn);
            this.panel2.Controls.Add(this.UpdateBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.Insert);
            this.panel2.Controls.Add(this.CourseIdText);
            this.panel2.Controls.Add(this.CidLabel);
            this.panel2.Controls.Add(this.CNameLabel);
            this.panel2.Controls.Add(this.CourseNametext);
            this.panel2.Controls.Add(this.CFeeLabel);
            this.panel2.Controls.Add(this.CourseFeeText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 471);
            this.panel2.TabIndex = 15;
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
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.DarkGreen;
            this.Insert.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.White;
            this.Insert.Location = new System.Drawing.Point(14, 353);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(141, 46);
            this.Insert.TabIndex = 13;
            this.Insert.Text = "INSERT";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // CourseIdText
            // 
            this.CourseIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseIdText.Location = new System.Drawing.Point(206, 66);
            this.CourseIdText.Name = "CourseIdText";
            this.CourseIdText.Size = new System.Drawing.Size(232, 32);
            this.CourseIdText.TabIndex = 4;
            // 
            // CidLabel
            // 
            this.CidLabel.AutoSize = true;
            this.CidLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CidLabel.Location = new System.Drawing.Point(31, 66);
            this.CidLabel.Name = "CidLabel";
            this.CidLabel.Size = new System.Drawing.Size(126, 30);
            this.CidLabel.TabIndex = 3;
            this.CidLabel.Text = "Course Id";
            // 
            // CNameLabel
            // 
            this.CNameLabel.AutoSize = true;
            this.CNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNameLabel.Location = new System.Drawing.Point(9, 137);
            this.CNameLabel.Name = "CNameLabel";
            this.CNameLabel.Size = new System.Drawing.Size(185, 30);
            this.CNameLabel.TabIndex = 5;
            this.CNameLabel.Text = " Course Name";
            // 
            // CourseNametext
            // 
            this.CourseNametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNametext.Location = new System.Drawing.Point(206, 135);
            this.CourseNametext.Name = "CourseNametext";
            this.CourseNametext.Size = new System.Drawing.Size(232, 32);
            this.CourseNametext.TabIndex = 6;
            // 
            // CFeeLabel
            // 
            this.CFeeLabel.AutoSize = true;
            this.CFeeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CFeeLabel.Location = new System.Drawing.Point(31, 204);
            this.CFeeLabel.Name = "CFeeLabel";
            this.CFeeLabel.Size = new System.Drawing.Size(148, 30);
            this.CFeeLabel.TabIndex = 7;
            this.CFeeLabel.Text = "Course Fee";
            // 
            // CourseFeeText
            // 
            this.CourseFeeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseFeeText.Location = new System.Drawing.Point(206, 202);
            this.CourseFeeText.Name = "CourseFeeText";
            this.CourseFeeText.Size = new System.Drawing.Size(232, 32);
            this.CourseFeeText.TabIndex = 8;
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.Location = new System.Drawing.Point(600, 90);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(381, 30);
            this.SearchtextBox.TabIndex = 19;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.Search);
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Searchlabel.Location = new System.Drawing.Point(519, 91);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(75, 31);
            this.Searchlabel.TabIndex = 17;
            this.Searchlabel.Text = "Serach";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(490, 141);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(577, 393);
            this.dataGridView.TabIndex = 18;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // ManageCourseForm
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
            this.Name = "ManageCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCourseForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
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
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox CourseIdText;
        private System.Windows.Forms.Label CidLabel;
        private System.Windows.Forms.Label CNameLabel;
        private System.Windows.Forms.TextBox CourseNametext;
        private System.Windows.Forms.Label CFeeLabel;
        private System.Windows.Forms.TextBox CourseFeeText;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}