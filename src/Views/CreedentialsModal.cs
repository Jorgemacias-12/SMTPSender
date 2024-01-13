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

namespace SMTPSender.src
{
    public partial class CreedentialsModal : Form
    {
        public EmailCredentials credentials = new EmailCredentials();

        public CreedentialsModal()
        {
            InitializeComponent();
        }

        private void Btn_SaveCredentials_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Email.Text))
            {
                MessageBox.Show($"El campo de correo no puede estar vació.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validations.IsEmail(Txt_Email.Text))
            {
                MessageBox.Show($"El correo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Txt_Password.Text))
            {
                MessageBox.Show($"El campo de contraseña no puede estar vació.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            credentials.Email = Txt_Email.Text;
            credentials.Password = Converters.ConvertToSecureString(Txt_Password.Text);

            MessageBox.Show($"¡Las credenciales de correo han sido guardadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dispose();
        }
    }
}
