using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class WellcomeForm : Form
    {
        public WellcomeForm()
        {
            InitializeComponent();
        }

        private void FormOnClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
