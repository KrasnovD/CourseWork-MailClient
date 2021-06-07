namespace MailClient
{
    partial class GUI_MailCreate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_MailCreate));
            this.rtBody = new System.Windows.Forms.RichTextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tbRecipient = new System.Windows.Forms.TextBox();
            this.Subject_Label = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtBody
            // 
            this.rtBody.BackColor = System.Drawing.Color.Snow;
            this.rtBody.Location = new System.Drawing.Point(12, 93);
            this.rtBody.Name = "rtBody";
            this.rtBody.Size = new System.Drawing.Size(832, 396);
            this.rtBody.TabIndex = 3;
            this.rtBody.Text = "";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Snow;
            this.buttonSend.BackgroundImage = global::MailClient.Properties.Resources._1613307318_34_p_sinii_kiber_fon_43;
            this.buttonSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSend.ForeColor = System.Drawing.Color.Snow;
            this.buttonSend.Location = new System.Drawing.Point(13, 3);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 40);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // tbRecipient
            // 
            this.tbRecipient.BackColor = System.Drawing.Color.Snow;
            this.tbRecipient.Location = new System.Drawing.Point(183, 14);
            this.tbRecipient.Name = "tbRecipient";
            this.tbRecipient.Size = new System.Drawing.Size(661, 20);
            this.tbRecipient.TabIndex = 0;
            this.tbRecipient.Validated += new System.EventHandler(this.tbRecipient_Validated);
            // 
            // Subject_Label
            // 
            this.Subject_Label.AutoSize = true;
            this.Subject_Label.BackColor = System.Drawing.Color.Black;
            this.Subject_Label.ForeColor = System.Drawing.Color.Snow;
            this.Subject_Label.Location = new System.Drawing.Point(140, 63);
            this.Subject_Label.Name = "Subject_Label";
            this.Subject_Label.Size = new System.Drawing.Size(37, 13);
            this.Subject_Label.TabIndex = 7;
            this.Subject_Label.Text = "Тема:";
            // 
            // tbSubject
            // 
            this.tbSubject.BackColor = System.Drawing.Color.Snow;
            this.tbSubject.Location = new System.Drawing.Point(183, 60);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(661, 20);
            this.tbSubject.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackgroundImage = global::MailClient.Properties.Resources._1613307318_34_p_sinii_kiber_fon_43;
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypt.ForeColor = System.Drawing.Color.Snow;
            this.buttonEncrypt.Image = global::MailClient.Properties.Resources._1613307318_34_p_sinii_kiber_fon_43;
            this.buttonEncrypt.Location = new System.Drawing.Point(12, 49);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(101, 38);
            this.buttonEncrypt.TabIndex = 4;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(140, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Кому:";
            // 
            // GUI_MailCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::MailClient.Properties.Resources._1613307318_34_p_sinii_kiber_fon_43;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(872, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.Subject_Label);
            this.Controls.Add(this.tbRecipient);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.rtBody);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_MailCreate";
            this.Text = "Новое сообщение";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBody;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox tbRecipient;
        private System.Windows.Forms.Label Subject_Label;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label1;
    }
}