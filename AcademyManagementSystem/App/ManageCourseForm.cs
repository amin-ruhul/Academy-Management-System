using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Repository;

namespace App
{
    public partial class ManageCourseForm : Form
    {
        internal Login l;
        internal Course c;
        private CourseRepo cr;
        public ManageCourseForm(Login l)
        {
            InitializeComponent();
            this.l = l;
            c = new Course();
            cr =  new CourseRepo();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            WellcomeForm wf = new WellcomeForm();
            wf.Show();
            this.Hide();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
           
           DataTable dt = cr.Select();
           dataGridView.DataSource = dt;
          
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (CourseIdText.Text == "" || CourseNametext.Text == "" || CourseFeeText.Text == "")
            {
                MessageBox.Show("Enter Info Correctly");
            }
            else
            {
                c.CourseId = CourseIdText.Text;
                c.CourseName = CourseNametext.Text;
                try
                {
                    c.CourseFee = double.Parse(CourseFeeText.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Enter double value");

                }
                
                bool success = cr.AddCourse(c);

                if (success == true)
                {
                    MessageBox.Show("Successfully Added.");
                    DataTable dt = cr.Select();
                    dataGridView.DataSource = dt;
                    Clear();

                }
                else
                {
                    MessageBox.Show("Faild");
                }
            }
        }

        public void Clear()
        {
            CourseIdText.Text = "";
            CourseNametext.Text = "";
            CourseFeeText.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CourseIdText.Text == "" || CourseNametext.Text == "" || CourseFeeText.Text == "")
            {
                MessageBox.Show("Enter Info Correctly.");
            }
            else
            {
                c.CourseId = CourseIdText.Text;
                c.CourseName = CourseNametext.Text;
                try
                {
                    c.CourseFee = double.Parse(CourseFeeText.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
               
                bool success = cr.UpdateCourse(c);
                if (success == true)
                {
                    MessageBox.Show("Update successfully");
                    DataTable dt = cr.Select();
                    dataGridView.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Faild!.");
                }

            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            c.CourseId = CourseIdText.Text;
           
            bool success = cr.DeleteCourse(c);

            if (success == true)
            {
                MessageBox.Show("Delete successfully");
                DataTable dt = cr.Select();
                dataGridView.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Faild");
            }
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;

            CourseIdText.Text = dataGridView.Rows[rowindex].Cells[0].Value.ToString();
            CourseNametext.Text = dataGridView.Rows[rowindex].Cells[1].Value.ToString();
            CourseFeeText.Text = dataGridView.Rows[rowindex].Cells[2].Value.ToString();

          
        }

        private void BackIcon_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm(l);
            ef.Show();
            this.Hide();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Search(object sender, EventArgs e)
        {
            string Keyword = SearchtextBox.Text;

            if (SearchtextBox.Text != null)
            {
                DataTable dt = cr.Search(Keyword);
                dataGridView.DataSource = dt;
            }
            else
            {
                DataTable dt = cr.Select();
                dataGridView.DataSource = dt;
            }
        }
    }
}
