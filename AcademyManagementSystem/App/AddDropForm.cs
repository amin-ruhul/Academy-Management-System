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
    public partial class AddDropForm : Form
    {
        private Login l;
        private Student s;
        private StudentRepo sr;
        private Course c;
        private CourseRepo cr;
        public AddDropForm(Login l)
        {
            InitializeComponent();
            s = new Student();
            sr = new StudentRepo();
            c = new Course();
            cr = new CourseRepo();
            this.l = l;
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private double totalfee;
        private int Flag;
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                s.Id = IdText.Text;
                DataTable dt = sr.SelectOne(s);

                IdText.Text = dt.Rows[0][0].ToString();
                nameTxt.Text = dt.Rows[0][1].ToString();
                emailText.Text = dt.Rows[0][2].ToString();
                courseTxt.Text = dt.Rows[0][3].ToString();
                //feesTxt.Text = dt.Rows[0][4].ToString();
                totalFeeTxt.Text = dt.Rows[0][4].ToString();
                string flag = dt.Rows[0][5].ToString();
                Flag = int.Parse(flag);

                totalfee = double.Parse(totalFeeTxt.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(IdText.Text +" Not Found!");
            }
           
        }

        private void CEnter_Click(object sender, EventArgs e)
        {
            try
            {
                c.CourseId = courseIdTxt.Text;
                DataTable dt = cr.GetCourse(c);
                courseIdTxt.Text = dt.Rows[0][0].ToString();
                courseNameTxt.Text = dt.Rows[0][1].ToString();
                courseFeeTxt.Text = dt.Rows[0][2].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(courseIdTxt.Text + " Not Found!");
            }
          
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            if (courseTxt.Text.Contains(courseNameTxt.Text))
            {
                MessageBox.Show(courseNameTxt.Text +" Already Taken");
            }
            else
            {

                courseTxt.Text = courseTxt.Text + " " + courseNameTxt.Text;
                // feesTxt.Text = feesTxt.Text + "," + courseFeeTxt.Text;
                string fee = courseFeeTxt.Text;
                totalfee += double.Parse(fee);
                totalFeeTxt.Text = totalfee.ToString();
            }
        }

        private void dropCourseBtn_Click(object sender, EventArgs e)
        {
            if (courseTxt.Text.Contains(courseNameTxt.Text))
            {

                courseTxt.Text = courseTxt.Text.Replace(courseNameTxt.Text, "");
                string fee = courseFeeTxt.Text;
                totalfee -= double.Parse(fee);
                totalFeeTxt.Text = totalfee.ToString();
            }
            else
            {
                MessageBox.Show(courseNameTxt.Text + " is not taken Before");
            }

           

        }

        private void BackIcon_Click(object sender, EventArgs e)
        {
            EmployeeForm ef= new EmployeeForm(l);
            ef.Show();
            this.Hide();
        }

        private void ConfirmedBtn_Click(object sender, EventArgs e)
        {
            s.Id = IdText.Text;
            s.Name = nameTxt.Text;
            s.Email = emailText.Text;
            s.Course = courseTxt.Text;
            s.TotalFee = double.Parse(totalFeeTxt.Text);
            s.Flag = Flag;

            bool success = sr.Update(s);

            if (success == true)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Faild");
            }

            All_Clear_Click(sender,e);

        }

        private void student_Clear_Click(object sender, EventArgs e)
        {
            IdText.Text = "";
            nameTxt.Text = "";
            emailText.Text = "";
            courseTxt.Text = "";
            totalFeeTxt.Text = "";
        }

        private void course_clear_Click(object sender, EventArgs e)
        {
            courseIdTxt.Text = "";
            courseNameTxt.Text = "";
            courseFeeTxt.Text = "";
        }

        private void All_Clear_Click(object sender, EventArgs e)
        {
            student_Clear_Click(sender,e);
            course_clear_Click(sender,e);
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            WellcomeForm wf = new WellcomeForm();
            wf.Show();
            this.Hide();
        }
    }
}
