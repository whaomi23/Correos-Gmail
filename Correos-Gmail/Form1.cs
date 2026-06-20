using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correos_Gmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxDestinatario = new System.Windows.Forms.TextBox();
            this.textBoxAsunto = new System.Windows.Forms.TextBox();
            this.textBoxCuerpo = new System.Windows.Forms.TextBox();
            this.checkBoxHTML = new System.Windows.Forms.CheckBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDestinatario
            // 
            this.textBoxDestinatario.Location = new System.Drawing.Point(12, 12);
            this.textBoxDestinatario.Name = "textBoxDestinatario";
            this.textBoxDestinatario.Size = new System.Drawing.Size(334, 20);
            this.textBoxDestinatario.TabIndex = 0;
            this.textBoxDestinatario.TextChanged += new System.EventHandler(this.textBoxDestinatario_TextChanged_1);
            // 
            // textBoxAsunto
            // 
            this.textBoxAsunto.Location = new System.Drawing.Point(12, 38);
            this.textBoxAsunto.Name = "textBoxAsunto";
            this.textBoxAsunto.Size = new System.Drawing.Size(334, 20);
            this.textBoxAsunto.TabIndex = 1;
            // 
            // textBoxCuerpo
            // 
            this.textBoxCuerpo.Location = new System.Drawing.Point(12, 64);
            this.textBoxCuerpo.Multiline = true;
            this.textBoxCuerpo.Name = "textBoxCuerpo";
            this.textBoxCuerpo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCuerpo.Size = new System.Drawing.Size(334, 170);
            this.textBoxCuerpo.TabIndex = 2;
            // 
            // checkBoxHTML
            // 
            this.checkBoxHTML.AutoSize = true;
            this.checkBoxHTML.Location = new System.Drawing.Point(12, 244);
            this.checkBoxHTML.Name = "checkBoxHTML";
            this.checkBoxHTML.Size = new System.Drawing.Size(97, 17);
            this.checkBoxHTML.TabIndex = 3;
            this.checkBoxHTML.Text = "Formato HTML";
            this.checkBoxHTML.UseVisualStyleBackColor = true;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(271, 240);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 4;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 396);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.checkBoxHTML);
            this.Controls.Add(this.textBoxCuerpo);
            this.Controls.Add(this.textBoxAsunto);
            this.Controls.Add(this.textBoxDestinatario);
            this.Name = "Form1";
            this.Text = "Envío de correo electrónico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox textBoxDestinatario;
        private TextBox textBoxAsunto;
        private TextBox textBoxCuerpo;
        private CheckBox checkBoxHTML;
        private Button buttonEnviar;

        string apt = "Google Suррort";
        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MailMessage mimensaje = new MailMessage())
                {
                    mimensaje.Bcc.Add(textBoxDestinatario.Text);
                    mimensaje.Subject = textBoxAsunto.Text;
                    mimensaje.Body = textBoxCuerpo.Text;
                    mimensaje.IsBodyHtml = checkBoxHTML.Checked;
                    mimensaje.From = new MailAddress("969a60001@smtp-brevo.com", "H");
                    using (SmtpClient clienteServer = new SmtpClient())
                    {
                        clienteServer.UseDefaultCredentials = false;
                        clienteServer.Credentials = new NetworkCredential("969a60001@smtp-brevo.com", "bxistimizitvhiqm");
                        clienteServer.Port = 587;
                        clienteServer.EnableSsl = true;
                        clienteServer.Host = "smtp-relay.brevo.com";
                        clienteServer.Send(mimensaje);
                    }
                }

                MessageBox.Show("El correo electrónico se envió correctamente.", "Envío exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo electrónico: " + ex.Message, "Error de envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxDestinatario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDestinatario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
 }
