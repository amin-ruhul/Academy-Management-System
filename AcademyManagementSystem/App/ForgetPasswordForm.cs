using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Repository;

namespace App
{
    public partial class ForgetPasswordForm : Form
    {
        internal Employee E;
        internal EmployeeRepo Er;
        public ForgetPasswordForm()
        {
            InitializeComponent();
            E = new Employee();
            Er = new EmployeeRepo();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {
            EmailgroupBox.Hide();
            PassgroupBox.Hide();
            CodegroupBox.Hide();
        }
        string To;
        string Code;
        string userId;
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            E.EmpId = userIdtextBox.Text;
            if (userIdtextBox.Text == "")
            {
                MessageBox.Show("Enter User ID");
            }
            else
            {
                userId = userIdtextBox.Text;
                E.EmpId = userId;

                DataTable dt = Er.MyInfo(E);
                To = dt.Rows[0][3].ToString();
                EmailgroupBox.Show();
                Mail.Text = To;
                //CodegroupBox.Hide();
                //PassgroupBox.Hide();
                UsergroupBox.Hide();
            }
        }

        private void GetBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Code = random.Next(999999).ToString();
            MailMessage message = new MailMessage();
            string form = "alphaacademy202@gmail.com";
            string password = "Alpha@202";
            string messageBody = "Your Reset Code:" + Code;
            message.To.Add(To);
            message.From = new MailAddress(form);
            message.Body = messageBody;
            message.Subject = "Reset Code";

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;
            client.Port = 587;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(form, password);

            try
            {
                client.Send(message);
                MessageBox.Show("Check your Email for code");
                CodegroupBox.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            
        }

        private void TextMBtn_Click(object sender, EventArgs e)
        {
            if (codetxt.Text == "")
            {
                MessageBox.Show("Enter your code.");
            }
            else
            {
                if (codetxt.Text == Code)
                {
                    PassgroupBox.Show();
                    CodegroupBox.Hide();
                    EmailgroupBox.Hide();
                }
                else
                {
                    MessageBox.Show("Code Not Match");
                }
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (newPassBox.Text == "" || conPassBox.Text == "")
            {

            }
            else
            {
                if (conPassBox.Text.Length < 8)
                {
                    MessageBox.Show("Password Must be 8 Characters or More");
                }
                else
                {

                    Login l = new Login();
                    LoginRepo lr = new LoginRepo();
                    l.UserId = userId;
                    l.Password = conPassBox.Text;
                    bool success = lr.ChangePassword(l);

                    if (success == true)
                    {
                        MessageBox.Show("Success!.You can Login Now");
                        newPassBox.Text = "";
                        conPassBox.Text = "";
                        LoginForm lf = new LoginForm();
                        lf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Faild");
                    }


                }
            }
        }

        private void BackIcon_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}
