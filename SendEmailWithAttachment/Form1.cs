using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendEmailWithAttachment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("harshini.venkatesan@atmecs.com");
                mail.To.Add("gowtham.mariappan@gmail.com");
                mail.Subject = "Test Mail - 1";
                mail.Body = "mail with attachment";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("harshini.venkatesan@atmecs.com", "Haha@1426vesa");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
