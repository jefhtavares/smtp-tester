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

namespace SmtpTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(txtPort.Value);
            var msgSender = txtUsername.Text;

            var receiver = string.IsNullOrEmpty(txtReceiver.Text) ? msgSender : txtReceiver.Text;

            var client = new SmtpClient(txtSmtp.Text, port)
            {
                EnableSsl = checkSsl.Checked,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            client.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);

            var message = new MailMessage
            {
                Body = "I'm just testing SMTP credentials",
                From = new MailAddress(msgSender, msgSender)
            };

            message.To.Add(receiver);
            
            try
            {
                txtOutput.Clear();
                client.Send(message);
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
            finally
            {
                client.Dispose();
            }
        }

        private void ProcessException(Exception ex)
        {
            string mainMessage = $"Exception: {ex.Message}{Environment.NewLine}{Environment.NewLine}";
            string innerMessages = "";

            var exception = ex;

            while (exception.InnerException != null)
            {
                innerMessages += $"Inner Exception: {exception.InnerException.Message}{Environment.NewLine}{Environment.NewLine}";

                exception = exception.InnerException;
            }

            txtOutput.Text += mainMessage;
            txtOutput.Text += innerMessages;
        }
    }
}
