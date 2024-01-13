namespace SMTPSender.src
{
    partial class CreedentialsModal
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
            this.Lbl_title = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_SaveCredentials = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_title
            // 
            this.Lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Size = new System.Drawing.Size(405, 29);
            this.Lbl_title.TabIndex = 0;
            this.Lbl_title.Text = "Iniciar sesión en los servicios de google";
            this.Lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.Location = new System.Drawing.Point(12, 42);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(381, 23);
            this.Lbl_Email.TabIndex = 1;
            this.Lbl_Email.Text = "Email";
            this.Lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(15, 68);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(378, 20);
            this.Txt_Email.TabIndex = 2;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.Location = new System.Drawing.Point(12, 100);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(381, 23);
            this.Lbl_Password.TabIndex = 3;
            this.Lbl_Password.Text = "Contraseña";
            this.Lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(12, 126);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(378, 20);
            this.Txt_Password.TabIndex = 4;
            // 
            // Btn_SaveCredentials
            // 
            this.Btn_SaveCredentials.Location = new System.Drawing.Point(12, 166);
            this.Btn_SaveCredentials.Name = "Btn_SaveCredentials";
            this.Btn_SaveCredentials.Size = new System.Drawing.Size(381, 28);
            this.Btn_SaveCredentials.TabIndex = 5;
            this.Btn_SaveCredentials.Text = "Guardar datos";
            this.Btn_SaveCredentials.UseVisualStyleBackColor = true;
            this.Btn_SaveCredentials.Click += new System.EventHandler(this.Btn_SaveCredentials_Click);
            // 
            // CreedentialsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 206);
            this.Controls.Add(this.Btn_SaveCredentials);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Lbl_title);
            this.MinimumSize = new System.Drawing.Size(421, 245);
            this.Name = "CreedentialsModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreedentialsModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_title;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_SaveCredentials;
    }
}