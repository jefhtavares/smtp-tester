using System;
using System.Net;
using System.Net.Mail;
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

            var msgSender = chkUsernameAsAddress.Checked ? txtUsername.Text : txtAddress.Text;
            var receiver = string.IsNullOrWhiteSpace(txtReceiver.Text) ? msgSender : txtReceiver.Text;
            
            var client = new SmtpClient(txtSmtp.Text, port)
            {
                EnableSsl = checkSsl.Checked,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text)
            };

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
