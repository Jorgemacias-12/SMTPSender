using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using SMTPSender.src.Controllers;

namespace SMTPSender.src.Views
{
    public partial class Emailer : Form
    {
        private EmailService service = EmailService.Service;
        private bool IsAuthenticated;
       

        public Emailer()
        {
            InitializeComponent();
        }

        private async void Btn_SendEmail_Click(object sender, EventArgs e)
        {
            IsAuthenticated = await service.Authenticate();

            if (!IsAuthenticated)
            {
                MessageBox.Show("¡Error!", "La autenticatión ha fallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("¡Información!", "La autenticación fue exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
