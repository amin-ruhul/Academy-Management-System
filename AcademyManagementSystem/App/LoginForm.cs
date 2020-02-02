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
    public partial class LoginForm : Form
    {
        internal Login l;
        public LoginForm()
        {
            InitializeComponent();
            l = new Login();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormOnClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserNameText.Text == "" || PasswordText.Text == "")
            {
                MessageBox.Show("Enter Info First.");
            }
            else
            {
              
              l.UserId = UserNameText.Text;
              l.Password = PasswordText.Text;
              LoginRepo lr = new LoginRepo();
              bool success = lr.LoginFunction(l);
              if (success == true)
              {
                  MessageBox.Show("Successfully Login.");
                  EmployeeForm ef = new EmployeeForm(l);
                  ef.Show();
                  this.Hide();
              }
              else
              {
                  MessageBox.Show("Faild");
              }

            }
        }

        private void ForgetPassword_Click(object sender, EventArgs e)
        {
           ForgetPasswordForm fp = new ForgetPasswordForm();
           fp.Show();
           this.Hide();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                PasswordText.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordText.UseSystemPasswordChar = true;
            }
        }

        private void BackIcon_Click(object sender, EventArgs e)
        {
            WellcomeForm wf = new WellcomeForm();
            wf.Show();
            this.Hide();
        }
    }
}
