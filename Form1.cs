using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace smtp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {



            MailAddress from = new MailAddress(ottb.Text);

            MailAddress to = new MailAddress(kotb.Text);

            MailMessage m = new MailMessage(from, to);

            m.Subject = "Hello from C#"; //тема

            m.Body = msg.Text;

            m.IsBodyHtml = false;

            m.SubjectEncoding = Encoding.UTF8;

            m.BodyEncoding = Encoding.UTF8;

            SmtpClient _smtp = new SmtpClient("smtp.yandex.ru", 465); //адрес и порт

            _smtp.Credentials = new NetworkCredential(ottb.Text, ptb.Text);

            _smtp.EnableSsl = true;

            
                _smtp.Send(m);
            

        }
    }
}
