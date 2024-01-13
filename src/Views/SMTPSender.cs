using SMTPSender.src;
using SMTPSender.src.Controllers;
using SMTPSender.src.Models;
using SMTPSender.src.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTPSender
{
    public partial class SMTPSender : Form
    {
        private Email email;
        private EmailCredentials credentials;
        private EmailSender emailSender;
        private EmailAttachment attachment;          

        public SMTPSender()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pnl_EmailRedact.Enabled = false;

            email = new Email();
            attachment = new EmailAttachment();
        }

        private void Btn_Creedentials_Click(object sender, EventArgs e)
        {
            CreedentialsModal modal = new CreedentialsModal();

            modal.ShowDialog();

            if (modal.credentials is null)
            {
                Logger.LogLine("Credentials are null or invalid idk why");
                
                return;
            }

            credentials = modal.credentials;

            Pnl_EmailRedact.Enabled = true;
        }

        private void Btn_SendEmail_Click(object sender, EventArgs e)
        {
            // Get all of the email data here
            if (string.IsNullOrEmpty(Txt_To.Text))
            {
                MessageBox.Show($"El campo de correo de destino no puede estar vació.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validations.IsEmail(Txt_To.Text))
            {
                MessageBox.Show($"El correo de destino no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Txt_Subject.Text))
            {
                MessageBox.Show($"El campo de asunto no puede estar vació.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Rtb_Body.Text))
            {
                MessageBox.Show($"El campo del mensaje no puede estar vació.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string subject;
            string destinationEmail;

            destinationEmail = Txt_To.Text;
            subject = Txt_Subject.Text;

            email.To = destinationEmail;
            email.From = credentials.Email;
            email.Subject = subject;
            email.Body = Rtb_Body.Text;

            EmailSender.SendEmail(credentials, email);

            MessageBox.Show($"¡Email enviado!", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_AddAttachments_Click(object sender, EventArgs e)
        {
            string[] Attachments;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                
                DialogResult result = openFileDialog.ShowDialog();
                
                if (result == DialogResult.Cancel || result == DialogResult.Abort ||
                    result == DialogResult.Abort)
                {
                    return;
                }

                Attachments = openFileDialog.FileNames;
            }

            foreach(string file in Attachments)
            {
                attachment.AttachFile = true;

                attachment.FilePath = file;

                email.Attachments.Add(attachment);
            }

            Logger.LogLine($"Attachments selected: {Attachments.Length}");
        }
    }
}