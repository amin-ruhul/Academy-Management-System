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
    public partial class ChangePassword : Form
    {
        internal Login l;
        public ChangePassword(Login l)
        {
            InitializeComponent();
            this.l = l;
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opEnterBtn_Click(object sender, EventArgs e)
        {
            if (oldPassBox.Text == "")
            {
                MessageBox.Show("Enter your Password First");
            }
            else
            {


                if (oldPassBox.Text.Equals(l.Password))
                {
                    oPlabel.Hide();
                    oldPassBox.Hide();
                    CPcheckBox.Hide();
                    opEnterBtn.Hide();
                    newPlabel.Show();
                    newPassBox.Show();
                    conPlabel.Show();
                    conPassBox.Show();
                    EntBtn.Show();
                    checkBox.Show();

                }
                else
                {
                    MessageBox.Show("Wrong Password!");
                    oldPassBox.Text = "";
                }
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            newPlabel.Hide();
            newPassBox.Hide();
            conPlabel.Hide();
            conPassBox.Hide();
            EntBtn.Hide();
            checkBox.Hide();
        }

        private void EntBtn_Click(object sender, EventArgs e)
        {
            if (newPassBox.Text == "" || conPassBox.Text == "")
            {
                MessageBox.Show("Fill the box first");
            }
            else
            {
                if (conPassBox.Text.Length < 8)
                {
                    MessageBox.Show("Password Must Be 8 Characters or More!");
                }
                else
                {


                    if (newPassBox.Text.Equals(conPassBox.Text))
                    {

                        l.Password = conPassBox.Text;
                        LoginRepo lr = new LoginRepo();
                        bool success = lr.ChangePassword(l);

                        if (success == true)
                        {
                            MessageBox.Show("Password Change Successfully.");
                            newPassBox.Text = "";
                            conPassBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Faild to change.");
                            newPassBox.Text = "";
                            conPassBox.Text = "";
                        }
                    }


                    else
                    {
                        MessageBox.Show("Password not match!");
                        newPassBox.Text = "";
                        conPassBox.Text = "";
                    }
                }
            }
        }

        private void CPcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CPcheckBox.Checked)
            {
                oldPassBox.UseSystemPasswordChar = false;
            }
            else
            {
                oldPassBox.UseSystemPasswordChar = true;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                newPassBox.UseSystemPasswordChar = false;
                conPassBox.UseSystemPasswordChar = false;
            }
            else
            {
                newPassBox.UseSystemPasswordChar = true;
                conPassBox.UseSystemPasswordChar = true;
            }
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            WellcomeForm wf = new WellcomeForm();
            wf.Show();
            this.Hide();
        }

        private void BackIcon_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm(l);
            ef.Show();
            this.Hide();
        }
    }
}
