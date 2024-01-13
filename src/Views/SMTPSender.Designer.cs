namespace SMTPSender
{
    partial class SMTPSender
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Creedentials = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_Topbar = new System.Windows.Forms.Panel();
            this.Pnl_Leftbar = new System.Windows.Forms.Panel();
            this.Lbl_EmailTo = new System.Windows.Forms.Label();
            this.Lbl_EmailRedact = new System.Windows.Forms.Label();
            this.Txt_To = new System.Windows.Forms.TextBox();
            this.Pnl_EmailRedact = new System.Windows.Forms.Panel();
            this.Btn_AddAttachments = new System.Windows.Forms.Button();
            this.Btn_SendEmail = new System.Windows.Forms.Button();
            this.Lbl_Body = new System.Windows.Forms.Label();
            this.Rtb_Body = new System.Windows.Forms.RichTextBox();
            this.Txt_Subject = new System.Windows.Forms.TextBox();
            this.Lbl_Subject = new System.Windows.Forms.Label();
            this.Pnl_Topbar.SuspendLayout();
            this.Pnl_EmailRedact.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Creedentials
            // 
            this.Btn_Creedentials.Location = new System.Drawing.Point(12, 12);
            this.Btn_Creedentials.Name = "Btn_Creedentials";
            this.Btn_Creedentials.Size = new System.Drawing.Size(151, 23);
            this.Btn_Creedentials.TabIndex = 0;
            this.Btn_Creedentials.Text = "Configurar envio de correos";
            this.Btn_Creedentials.UseVisualStyleBackColor = true;
            this.Btn_Creedentials.Click += new System.EventHandler(this.Btn_Creedentials_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Location = new System.Drawing.Point(169, 17);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(191, 13);
            this.Lbl_Title.TabIndex = 1;
            this.Lbl_Title.Text = "Prueba de envio de correos por código";
            // 
            // Pnl_Topbar
            // 
            this.Pnl_Topbar.BackColor = System.Drawing.SystemColors.Window;
            this.Pnl_Topbar.Controls.Add(this.Btn_Creedentials);
            this.Pnl_Topbar.Controls.Add(this.Lbl_Title);
            this.Pnl_Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Topbar.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Topbar.Name = "Pnl_Topbar";
            this.Pnl_Topbar.Size = new System.Drawing.Size(703, 43);
            this.Pnl_Topbar.TabIndex = 2;
            // 
            // Pnl_Leftbar
            // 
            this.Pnl_Leftbar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pnl_Leftbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Leftbar.Location = new System.Drawing.Point(0, 43);
            this.Pnl_Leftbar.Name = "Pnl_Leftbar";
            this.Pnl_Leftbar.Size = new System.Drawing.Size(163, 404);
            this.Pnl_Leftbar.TabIndex = 3;
            // 
            // Lbl_EmailTo
            // 
            this.Lbl_EmailTo.AutoSize = true;
            this.Lbl_EmailTo.Location = new System.Drawing.Point(6, 54);
            this.Lbl_EmailTo.Name = "Lbl_EmailTo";
            this.Lbl_EmailTo.Size = new System.Drawing.Size(32, 13);
            this.Lbl_EmailTo.TabIndex = 4;
            this.Lbl_EmailTo.Text = "Para:";
            // 
            // Lbl_EmailRedact
            // 
            this.Lbl_EmailRedact.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_EmailRedact.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_EmailRedact.Location = new System.Drawing.Point(0, 0);
            this.Lbl_EmailRedact.Name = "Lbl_EmailRedact";
            this.Lbl_EmailRedact.Size = new System.Drawing.Size(540, 45);
            this.Lbl_EmailRedact.TabIndex = 5;
            this.Lbl_EmailRedact.Text = "Redactar correo";
            this.Lbl_EmailRedact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_To
            // 
            this.Txt_To.Location = new System.Drawing.Point(44, 51);
            this.Txt_To.Name = "Txt_To";
            this.Txt_To.Size = new System.Drawing.Size(484, 20);
            this.Txt_To.TabIndex = 6;
            // 
            // Pnl_EmailRedact
            // 
            this.Pnl_EmailRedact.Controls.Add(this.Btn_AddAttachments);
            this.Pnl_EmailRedact.Controls.Add(this.Btn_SendEmail);
            this.Pnl_EmailRedact.Controls.Add(this.Lbl_Body);
            this.Pnl_EmailRedact.Controls.Add(this.Rtb_Body);
            this.Pnl_EmailRedact.Controls.Add(this.Txt_Subject);
            this.Pnl_EmailRedact.Controls.Add(this.Lbl_Subject);
            this.Pnl_EmailRedact.Controls.Add(this.Txt_To);
            this.Pnl_EmailRedact.Controls.Add(this.Lbl_EmailRedact);
            this.Pnl_EmailRedact.Controls.Add(this.Lbl_EmailTo);
            this.Pnl_EmailRedact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_EmailRedact.Location = new System.Drawing.Point(163, 43);
            this.Pnl_EmailRedact.Name = "Pnl_EmailRedact";
            this.Pnl_EmailRedact.Size = new System.Drawing.Size(540, 404);
            this.Pnl_EmailRedact.TabIndex = 4;
            // 
            // Btn_AddAttachments
            // 
            this.Btn_AddAttachments.Location = new System.Drawing.Point(140, 369);
            this.Btn_AddAttachments.Name = "Btn_AddAttachments";
            this.Btn_AddAttachments.Size = new System.Drawing.Size(122, 23);
            this.Btn_AddAttachments.TabIndex = 12;
            this.Btn_AddAttachments.Text = "Añadir archivo(s)";
            this.Btn_AddAttachments.UseVisualStyleBackColor = true;
            this.Btn_AddAttachments.Click += new System.EventHandler(this.Btn_AddAttachments_Click);
            // 
            // Btn_SendEmail
            // 
            this.Btn_SendEmail.Location = new System.Drawing.Point(12, 369);
            this.Btn_SendEmail.Name = "Btn_SendEmail";
            this.Btn_SendEmail.Size = new System.Drawing.Size(122, 23);
            this.Btn_SendEmail.TabIndex = 11;
            this.Btn_SendEmail.Text = "Enviar correo";
            this.Btn_SendEmail.UseVisualStyleBackColor = true;
            this.Btn_SendEmail.Click += new System.EventHandler(this.Btn_SendEmail_Click);
            // 
            // Lbl_Body
            // 
            this.Lbl_Body.Location = new System.Drawing.Point(9, 125);
            this.Lbl_Body.Name = "Lbl_Body";
            this.Lbl_Body.Size = new System.Drawing.Size(519, 20);
            this.Lbl_Body.TabIndex = 10;
            this.Lbl_Body.Text = "Cuerpo del mensaje:";
            this.Lbl_Body.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rtb_Body
            // 
            this.Rtb_Body.Location = new System.Drawing.Point(9, 148);
            this.Rtb_Body.Name = "Rtb_Body";
            this.Rtb_Body.Size = new System.Drawing.Size(519, 184);
            this.Rtb_Body.TabIndex = 9;
            this.Rtb_Body.Text = "";
            // 
            // Txt_Subject
            // 
            this.Txt_Subject.Location = new System.Drawing.Point(55, 89);
            this.Txt_Subject.Name = "Txt_Subject";
            this.Txt_Subject.Size = new System.Drawing.Size(473, 20);
            this.Txt_Subject.TabIndex = 8;
            // 
            // Lbl_Subject
            // 
            this.Lbl_Subject.AutoSize = true;
            this.Lbl_Subject.Location = new System.Drawing.Point(6, 92);
            this.Lbl_Subject.Name = "Lbl_Subject";
            this.Lbl_Subject.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Subject.TabIndex = 7;
            this.Lbl_Subject.Text = "Asunto:";
            // 
            // SMTPSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(703, 447);
            this.Controls.Add(this.Pnl_EmailRedact);
            this.Controls.Add(this.Pnl_Leftbar);
            this.Controls.Add(this.Pnl_Topbar);
            this.Name = "SMTPSender";
            this.Text = "STMP Email sender (google)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pnl_Topbar.ResumeLayout(false);
            this.Pnl_Topbar.PerformLayout();
            this.Pnl_EmailRedact.ResumeLayout(false);
            this.Pnl_EmailRedact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Creedentials;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel Pnl_Topbar;
        private System.Windows.Forms.Panel Pnl_Leftbar;
        private System.Windows.Forms.Label Lbl_EmailTo;
        private System.Windows.Forms.Label Lbl_EmailRedact;
        private System.Windows.Forms.TextBox Txt_To;
        private System.Windows.Forms.Panel Pnl_EmailRedact;
        private System.Windows.Forms.TextBox Txt_Subject;
        private System.Windows.Forms.Label Lbl_Subject;
        private System.Windows.Forms.RichTextBox Rtb_Body;
        private System.Windows.Forms.Label Lbl_Body;
        private System.Windows.Forms.Button Btn_SendEmail;
        private System.Windows.Forms.Button Btn_AddAttachments;
    }
}

