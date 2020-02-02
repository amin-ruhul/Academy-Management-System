using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entity;
using Repository;

namespace App
{
    public partial class ManageStudentForm : Form
    {
        private Student s;
        private StudentRepo sr;
        private CourseRepo cr;
        Login l;
        public ManageStudentForm(Login l)
        {
            InitializeComponent();
            s = new Student();
            sr = new StudentRepo();
            cr =  new CourseRepo();
            this.l = l;
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
           
            DataTable dt = cr.Select();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CourseCombo.Items.Add(dt.Rows[i]["CourseName"]);
            }

            DataTable table = sr.Select();
            dataGridView.DataSource = table;
            addBtn.Enabled = true;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "" || NameTextBox.Text == "" || EmailTextBox.Text == "" || CourseTextBox.Text == "")
            {
                MessageBox.Show("Enter All Info Correctly");
            }
            else
            {
                s.Id = IdTextBox.Text;
                s.Name = NameTextBox.Text;
                s.Email = EmailTextBox.Text;
                s.Course = CourseTextBox.Text;
               // s.Fees = FeesTxt.Text;
                s.TotalFee = totalfee;
                s.Flag = 0;

                bool success = sr.Insert(s);

                if (success == true)
                {
                    MessageBox.Show("success");

                }
                else
                {
                    MessageBox.Show("Faild");
                }

                DataTable dt = sr.Select();
                dataGridView.DataSource = dt;
                Clear();


            }
        }

        private double totalfee=0;
        //private string fees;
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CourseCombo.Text == "")
            {
                MessageBox.Show("select your course first");
            }
            else
            {


                string cName = CourseCombo.Text;
                DataTable dt = cr.GetPrice(cName);
                feeBox.Text = dt.Rows[0][2].ToString();

                if (CourseTextBox.Text.Contains(cName))
                {
                    MessageBox.Show(cName+" Already Taken!");
                }
                else
                {


                    CourseTextBox.Text = CourseTextBox.Text + " " + cName;
                    string fee = feeBox.Text;
                    FeesTxt.Text = FeesTxt.Text + "," + fee;


                    // fees = feeBox.Text + "," + fee;

                    double total = double.Parse(fee);
                    totalfee += total;
                    totalFeeBox.Text = totalfee.ToString();
                }
            }

        }

        public void Clear()
        {
            IdTextBox.Text = "";
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            CourseTextBox.Text = "";
            feeBox.Text = "";
            totalFeeBox.Text = "";
            totalfee = 0;
            FeesTxt.Text = "";
            CourseCombo.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || EmailTextBox.Text == "")
            {
                MessageBox.Show("Enter info Correctly.");
            }
            else
            {
                s.Id = IdTextBox.Text;
                s.Name = NameTextBox.Text;
                s.Email = EmailTextBox.Text;
                s.Course = CourseTextBox.Text;
               // s.Fees = FeesTxt.Text;
                s.TotalFee = double.Parse(totalFeeBox.Text);
                s.Flag = 0;

                bool success = sr.Update(s);
                if (success == true)
                {
                    MessageBox.Show("Updated.");
                }
                else
                {
                    MessageBox.Show("Faild");
                }
                DataTable dt = sr.Select();
                dataGridView.DataSource = dt;
                Clear();
                addBtn.Enabled = true;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            s.Id = IdTextBox.Text;
            bool success = sr.Delete(s);
            if (success == true)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Faild");
            }
            DataTable dt = sr.Select();
            dataGridView.DataSource = dt;
            Clear();
            addBtn.Enabled = true;
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            IdTextBox.Text = dataGridView.Rows[rowindex].Cells[0].Value.ToString();
            NameTextBox.Text = dataGridView.Rows[rowindex].Cells[1].Value.ToString();
            EmailTextBox.Text = dataGridView.Rows[rowindex].Cells[2].Value.ToString();
            CourseTextBox.Text = dataGridView.Rows[rowindex].Cells[3].Value.ToString();
            //feeBox.Text = dataGridView.Rows[rowindex].Cells[4].Value.ToString();
            totalFeeBox.Text = dataGridView.Rows[rowindex].Cells[4].Value.ToString();
            addBtn.Enabled = false;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
            addBtn.Enabled = true;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string Keyword = SearchBox.Text;

            if (SearchBox.Text != null)
            {
                DataTable dt = sr.Search(Keyword);
                dataGridView.DataSource = dt;
            }
            else
            {
                DataTable dt = sr.Select();
                dataGridView.DataSource = dt;
            }
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            WellcomeForm wf = new WellcomeForm();
            wf.Show();
            this.Close();
        }

        private void BackIcon_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm(l);
            ef.Show();
            this.Hide();
        }
    }
}
