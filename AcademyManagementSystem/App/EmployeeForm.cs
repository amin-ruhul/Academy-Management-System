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
    public partial class EmployeeForm : Form
    {
        internal Login l;
        private int status;
        internal Employee E;
        private EmployeeRepo er;
        public EmployeeForm(Login l)
        {
            InitializeComponent();
            this.l = l;
            E = new Employee();
            er = new EmployeeRepo();
            userName.Text = l.UserId;
           
        }

        private void FormOnClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageEmp_Click(object sender, EventArgs e)
        {
            if (status == 1 || status == 2)
            {
                ManageEmployeeForm mf = new ManageEmployeeForm(l);
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
          
        }

        private void mCourse_Click(object sender, EventArgs e)
        {
            ManageCourseForm mf = new ManageCourseForm(l);
          
            mf.Show();
            this.Hide();
        }

        private void chanPass_Click(object sender, EventArgs e)
        {
           ChangePassword cp = new ChangePassword(l);
           cp.Show();
           this.Hide();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

            DashBord.BackColor = Color.BlueViolet;
            E.EmpId = l.UserId;
            DashBord_Click(sender,e);
           

             LoginRepo lr = new LoginRepo();
             DataTable dt = lr.LoadData(l);
             status = int.Parse(dt.Rows[0][2].ToString());
            
        }

        private void MyInfo_Click(object sender, EventArgs e)
        {
           
          AddDropForm adf = new AddDropForm(l);
          adf.Show();
          this.Hide();
        }

        private void mStudent_Click(object sender, EventArgs e)
        {
           ManageStudentForm mf = new ManageStudentForm(l);
           mf.Show();
           this.Hide();
        }

        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            WellcomeForm wf = new WellcomeForm();
            wf.Show();
            this.Hide();
        }

        private void mPrement_Click(object sender, EventArgs e)
        {
            if (status == 1 || status == 2)
            {
                ManagePaymentForm mp = new ManagePaymentForm(l);
                mp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
          
        }

        private void LabelMouseEnter(object sender, EventArgs e)
        {
            Label label = (Label) sender;
            label.BackColor = Color.BlueViolet;
        }

        private void LabelMouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            
            if (label.Text != "DASHBORD")
            {
                DashBord.BackColor = default;
            }
            label.BackColor = default;
        }

        private void DashBord_Click(object sender, EventArgs e)
        {
            DataTable dt = er.MyInfo(E);
            IdLabel.Text = dt.Rows[0][0].ToString();
            NameLabel.Text = dt.Rows[0][1].ToString();
            Salarylabel.Text = dt.Rows[0][2].ToString();
            Emaillabel.Text = dt.Rows[0][3].ToString();
            Genderlabel.Text = dt.Rows[0][4].ToString();
            Deglabel.Text = dt.Rows[0][5].ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
