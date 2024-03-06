using SMTPSender.src.Components;

namespace SMTPSender.src.Views
{
    partial class Emailer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_SendEmail = new System.Windows.Forms.Button();
            this.Pnl_Controls = new System.Windows.Forms.Panel();
            this.Lbl_Body = new System.Windows.Forms.Label();
            this.Rtb_Body = new System.Windows.Forms.RichTextBox();
            this.Txt_Subject = new System.Windows.Forms.TextBox();
            this.Lbl_Subject = new System.Windows.Forms.Label();
            this.Txt_To = new System.Windows.Forms.TextBox();
            this.Lbl_EmailTo = new System.Windows.Forms.Label();
            this.Pnl_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(224, 13);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Prueba de autenticación con google OAuthv2";
            // 
            // Btn_SendEmail
            // 
            this.Btn_SendEmail.Location = new System.Drawing.Point(887, 640);
            this.Btn_SendEmail.Name = "Btn_SendEmail";
            this.Btn_SendEmail.Size = new System.Drawing.Size(122, 23);
            this.Btn_SendEmail.TabIndex = 12;
            this.Btn_SendEmail.Text = "Enviar correo";
            this.Btn_SendEmail.UseVisualStyleBackColor = true;
            this.Btn_SendEmail.Click += new System.EventHandler(this.Btn_SendEmail_Click);
            // 
            // Pnl_Controls
            // 
            this.Pnl_Controls.Controls.Add(this.Lbl_Body);
            this.Pnl_Controls.Controls.Add(this.Rtb_Body);
            this.Pnl_Controls.Controls.Add(this.Txt_Subject);
            this.Pnl_Controls.Controls.Add(this.Lbl_Subject);
            this.Pnl_Controls.Controls.Add(this.Txt_To);
            this.Pnl_Controls.Controls.Add(this.Lbl_EmailTo);
            this.Pnl_Controls.Location = new System.Drawing.Point(15, 34);
            this.Pnl_Controls.Name = "Pnl_Controls";
            this.Pnl_Controls.Size = new System.Drawing.Size(530, 629);
            this.Pnl_Controls.TabIndex = 13;
            // 
            // Lbl_Body
            // 
            this.Lbl_Body.Location = new System.Drawing.Point(4, 68);
            this.Lbl_Body.Name = "Lbl_Body";
            this.Lbl_Body.Size = new System.Drawing.Size(523, 20);
            this.Lbl_Body.TabIndex = 24;
            this.Lbl_Body.Text = "Cuerpo del mensaje:";
            this.Lbl_Body.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rtb_Body
            // 
            this.Rtb_Body.Location = new System.Drawing.Point(4, 91);
            this.Rtb_Body.Name = "Rtb_Body";
            this.Rtb_Body.Size = new System.Drawing.Size(523, 536);
            this.Rtb_Body.TabIndex = 23;
            this.Rtb_Body.Text = "";
            // 
            // Txt_Subject
            // 
            this.Txt_Subject.Location = new System.Drawing.Point(54, 39);
            this.Txt_Subject.Name = "Txt_Subject";
            this.Txt_Subject.Size = new System.Drawing.Size(473, 20);
            this.Txt_Subject.TabIndex = 22;
            // 
            // Lbl_Subject
            // 
            this.Lbl_Subject.AutoSize = true;
            this.Lbl_Subject.Location = new System.Drawing.Point(5, 42);
            this.Lbl_Subject.Name = "Lbl_Subject";
            this.Lbl_Subject.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Subject.TabIndex = 21;
            this.Lbl_Subject.Text = "Asunto:";
            // 
            // Txt_To
            // 
            this.Txt_To.Location = new System.Drawing.Point(43, 1);
            this.Txt_To.Name = "Txt_To";
            this.Txt_To.Size = new System.Drawing.Size(484, 20);
            this.Txt_To.TabIndex = 20;
            // 
            // Lbl_EmailTo
            // 
            this.Lbl_EmailTo.AutoSize = true;
            this.Lbl_EmailTo.Location = new System.Drawing.Point(5, 4);
            this.Lbl_EmailTo.Name = "Lbl_EmailTo";
            this.Lbl_EmailTo.Size = new System.Drawing.Size(32, 13);
            this.Lbl_EmailTo.TabIndex = 19;
            this.Lbl_EmailTo.Text = "Para:";
            // 
            // Emailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 675);
            this.Controls.Add(this.Pnl_Controls);
            this.Controls.Add(this.Btn_SendEmail);
            this.Controls.Add(this.Lbl_Title);
            this.Name = "Emailer";
            this.Text = "Emailer";
            this.Pnl_Controls.ResumeLayout(false);
            this.Pnl_Controls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Button Btn_SendEmail;
        private System.Windows.Forms.Panel Pnl_Controls;
        private System.Windows.Forms.Label Lbl_Body;
        private System.Windows.Forms.RichTextBox Rtb_Body;
        private System.Windows.Forms.TextBox Txt_Subject;
        private System.Windows.Forms.Label Lbl_Subject;
        private System.Windows.Forms.TextBox Txt_To;
        private System.Windows.Forms.Label Lbl_EmailTo;
    }
}