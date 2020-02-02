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
    public partial class ManageEmployeeForm : Form
    {
        internal Login l;
        internal Employee E;
        private EmployeeRepo er;
        private LoginRepo lr;
        public ManageEmployeeForm(Login l)
        {
            InitializeComponent();
            this.l = l;
            E = new Employee();
            er = new EmployeeRepo();
            lr = new LoginRepo();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// ************Insert Employee**********************************
        private void InsertEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (EIdText.Text == "" || ENametext.Text == "" || ESalarytext.Text == "" || EEmailText.Text == "" ||
                genderBox.Text == "" || DesiBox.Text == "")
            {
                MessageBox.Show("Enter Your Information Correctly");
            }
            else
            {
                E.EmpId = EIdText.Text;
                E.EmpName = ENametext.Text;
                E.EmpEmail = EEmailText.Text;
                E.Gender = genderBox.Text;
                E.Designation = DesiBox.Text;

                try
                {
                    E.EmpSalary = double.Parse(ESalarytext.Text);
                   

                    bool success = er.Insert(E);

                    if (success == true)
                    {
                        l.Password = PasswordGenerator();
                        l.UserId = EIdText.Text;

                        if (DesiBox.Text.Equals("TRAINER", StringComparison.OrdinalIgnoreCase))
                        {
                            l.Status = 3;
                        }
                        else if (DesiBox.Text.Equals("MANAGER", StringComparison.OrdinalIgnoreCase))
                        {
                            l.Status = 2;
                        }
                        else if (DesiBox.Text.Equals("ADMIN", StringComparison.OrdinalIgnoreCase))
                        {
                            l.Status = 1;
                        }
                        else if (DesiBox.Text.Equals("OTHER", StringComparison.OrdinalIgnoreCase))
                        {
                            l.Status = 4;
                        }
                        
                        lr.InsertUser(l);
                    }
                    else
                    {
                        MessageBox.Show("Faild!");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                DataTable dt = er.Select();
                dataGridView.DataSource = dt;
                Clear();
            }
        }
      
        
        /// ************Random Password**********************************
        public string PasswordGenerator()
        {
            string availChar = "abc123";

            StringBuilder password = new StringBuilder();
            Random ran = new Random();
            int passlength = ran.Next(6, 8);
            while (passlength-- > 0)
                password.Append(availChar[ran.Next(availChar.Length)]);
            //MessageBox.Show(password.ToString());
            MessageBox.Show("Your password is: " + password.ToString());
            return password.ToString();
        }


        /// ************Clear all field**********************************
        public void Clear()
        {
            EIdText.Text = "";
            ENametext.Text = "";
            ESalarytext.Text = "";
            EEmailText.Text = "";
            genderBox.Text = "";
            DesiBox.Text = default;
        }

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            EmployeeRepo er = new EmployeeRepo();
            DataTable dt = er.Select();
            dataGridView.DataSource = dt;
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            EIdText.Text = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            ENametext.Text = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            ESalarytext.Text = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            EEmailText.Text = dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            genderBox.Text = dataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            DesiBox.Text = dataGridView.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (EIdText.Text == "" || ENametext.Text == "" || ESalarytext.Text == "" || EEmailText.Text == "" || genderBox.Text == "" || DesiBox.Text == "")
            {
                MessageBox.Show("Enter Your Information Correctly");
            }
            else
            {
                E.EmpId = EIdText.Text;
                E.EmpName = ENametext.Text;
                try
                {
                    E.EmpSalary = double.Parse(ESalarytext.Text);

                    E.EmpEmail = EEmailText.Text;
                    E.Gender = genderBox.Text;
                    E.Designation = DesiBox.Text;

                    bool success = er.Update(E);

                    if (success == true)
                    {

                        MessageBox.Show("Successfully Update.");
                        DataTable dt = er.Select();
                        dataGridView.DataSource = dt;
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Faild!");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (l.UserId == EIdText.Text)
            {
                MessageBox.Show("You Can not Delete Yourself");
            }
            else
            {

                E.EmpId = EIdText.Text;
                l.UserId = EIdText.Text;

                bool success = er.Delete(E);
                if (success == true)
                {
                    lr.DeleteUser(l);
                    MessageBox.Show("Successfully Deleted.");
                    DataTable dt = er.Select();
                    dataGridView.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Faild!");
                }
            }
        }

        private void Search(object sender, EventArgs e)
        {
            string keyword = SearchtextBox.Text;

            DataTable dt = er.Search(keyword);
            dataGridView.DataSource = dt;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
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
