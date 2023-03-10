using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace PuntoInformacion
{
    public partial class PantallaSugerencias : UserControl
    {
        public PantallaSugerencias()
        {
            InitializeComponent();
        }

        private void textBoxMensaje_TextChanged(object sender, EventArgs e)
        {
            textBoxMensaje.SelectionStart = textBoxMensaje.Text.Length;
            textBoxMensaje.ScrollToCaret();
        }

        private void vaciarCampos()
        {
            textBoxNombre.Text = "";
            textBoxMensaje.Text = "";
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (textBoxMensaje.Text.Equals(""))
            {
                MessageBox.Show("Por favor, rellene el campo de mensaje", "Falta mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            enviarMail();
            vaciarCampos();

            MessageBox.Show("Se ha enviado el email correctamente", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private MailMessage prepararMail()
        {
            MailMessage msgMail = new MailMessage();

            MailAddress origen = new MailAddress("sugerencias@cescristorey.com");
            MailAddress destinatario = new MailAddress("sugerencias@cescristorey.com");
            msgMail.From = origen;
            msgMail.To.Add(destinatario);
            
            String nombreDestinatario;
            if (this.textBoxNombre.Text.Equals(""))
            {
                nombreDestinatario = "Anónima";
            }
            else
            {
                nombreDestinatario = this.textBoxNombre.Text;
            }

            msgMail.Subject = "Sugerencia " + nombreDestinatario;
            msgMail.IsBodyHtml = true;
            msgMail.Body = this.textBoxMensaje.Text;
   
            return msgMail;
        }
        private void enviarMail()
        {
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com");

            mailClient.Port = 587;
            mailClient.UseDefaultCredentials = false;
            mailClient.EnableSsl = true;

            mailClient.Credentials = new System.Net.NetworkCredential("sugerencias@cescristorey.com", "2DAM2021");

            mailClient.Send(prepararMail());
        }
    }
}
