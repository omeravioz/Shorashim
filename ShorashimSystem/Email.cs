using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace ShorashimSystem
{
    class Email
    {


        public static void sendingEmail(String CustomerEmail, String message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("shorashimmail1@gmail.com");
                mail.To.Add(CustomerEmail);
                mail.Subject = "A gift from Shorashim - Promotion Code";
                mail.Body = message;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("shorashimmail1@gmail.com", "shorashim1234");///
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
