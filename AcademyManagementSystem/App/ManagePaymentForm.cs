using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entity;
using IronPdf;
using Repository;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace App
{
    public partial class ManagePaymentForm : Form
    {
        internal Login l;
        internal Student s;
        internal StudentRepo sr;
       
       
        public ManagePaymentForm(Login l)
        {
            InitializeComponent();
            this.l = l;
            s = new Student();
            sr = new StudentRepo();
           
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
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

        private int Flag;
        private double totalfee;
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

                totalfee = double.Parse(totalFeeTxt.Text);
                double haffee = totalfee * 0.5;
                Flag = int.Parse(flag);
                fullTxt.Text = totalfee.ToString();
                hafTxt.Text = haffee.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(" " +IdText.Text+" is not valid Id");
            }
           

        }


        public void PdfGenetator()
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("C:\\Users\\ASUS\\Desktop\\Bot Autosearch\\" + IdText.Text + ".pdf", FileMode.Create)); doc.Open();
            iTextSharp.text.Font font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.COURIER.ToString(), 14);
            iTextSharp.text.Font font1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.COURIER.ToString(), 20, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font3 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.COURIER.ToString(), 10, iTextSharp.text.Font.BOLD);
            doc.Open();
            Paragraph para1 = new Paragraph("Alpha Academy", font1);
            para1.Alignment = Element.ALIGN_CENTER;
            Paragraph para2 = new Paragraph("XXX-Dhaka-XXX", font3);
            para2.Alignment = Element.ALIGN_CENTER;
            para2.SpacingAfter = 100;

            Paragraph para3 = new Paragraph("Id: " + IdText.Text, font);
            Paragraph para4 = new Paragraph("Name: " + nameTxt.Text, font);
            Paragraph para5 = new Paragraph("Name: " + emailText.Text, font);
            Paragraph para6 = new Paragraph("Course: " + courseTxt.Text, font);
            para6.SpacingAfter = 110;
            Paragraph para7 = new Paragraph("-------------------------------------------------------------------");
            para7.Alignment = Element.ALIGN_CENTER;
            para7.SpacingAfter = 50;
            Paragraph para8 = new Paragraph("Alpha Academy", font1);
            para8.Alignment = Element.ALIGN_CENTER;
            Paragraph para9 = new Paragraph("XXX-Dhaka-XXX", font3);
            para9.Alignment = Element.ALIGN_CENTER;
            para9.SpacingAfter = 20;
            Paragraph para10 = new Paragraph(IdText.Text + "," + nameTxt.Text, font);
            para10.Alignment = Element.ALIGN_CENTER;
            para10.SpacingAfter = 40;
            Paragraph para11 = new Paragraph("Payment Date: ..................", font);
            Paragraph para12 = new Paragraph("Bank Name: XXX-XXX", font);
            Paragraph para13 = new Paragraph("Bank Name: XXX-XXX", font);
            Paragraph para14 = new Paragraph("Account Name:Alpha Academy", font);
            Paragraph para15 = new Paragraph("Amount: " + hafTxt.Text + " Taka Only.", font);
            Paragraph para16 = new Paragraph("Signature(Deposite By): .................", font);

            doc.Add(para1);
            doc.Add(para2);
            doc.Add(para3);
            doc.Add(para4);
            doc.Add(para5);
            doc.Add(para6);
            doc.Add(para7);
            doc.Add(para8);
            doc.Add(para9);
            doc.Add(para10);
            doc.Add(para11);
            doc.Add(para12);
            doc.Add(para13);
            doc.Add(para14);
            doc.Add(para15);
            doc.Add(para16);

            doc.Close();

        }


        private void FullBtn_Click(object sender, EventArgs e)
        {
           
            
                s.Id = IdText.Text;
                s.Name = nameTxt.Text;
                s.Course = courseTxt.Text;
               // s.Fees = feesTxt.Text;
                s.Email = emailText.Text;
                s.Flag = 1;
                s.TotalFee = 0;
                bool success = sr.Update(s);
                if (success == true)
                {
                    
                    PdfGenetator();
                    MessageBox.Show("success");
                    

                }
                else

                {
                    MessageBox.Show("Faild");
                }
                Clear();
            
        }

        public void Clear()
        {
            IdText.Text = "";
            nameTxt.Text = "";
            emailText.Text = "";
            courseTxt.Text = "";
           
            totalFeeTxt.Text = "";
            fullTxt.Text = "";
            hafTxt.Text = "";
            
        }

        private void HafBtn_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                MessageBox.Show("Denied!");
            }
            else
            {
                s.Id = IdText.Text;
                s.Name = nameTxt.Text;
                s.Course = courseTxt.Text;
               // s.Fees = feesTxt.Text;
                s.Email = emailText.Text;
                s.Flag = 1;
                s.TotalFee = totalfee * 0.5;
                bool success = sr.Update(s);
                if (success == true)
                {
                  
                    PdfGenetator();
                    MessageBox.Show("success");
                    
                }
                else
                {
                    MessageBox.Show("Faild");
                }
                Clear();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BackIcon_Click(object sender, EventArgs e)
        {
            
                EmployeeForm ef = new EmployeeForm(l);
                ef.Show();
                this.Hide();
            
        }

       
    }
}
