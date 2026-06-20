namespace Correos_Gmail
{
    partial class Form1
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
        /// </summary


        private void Initializet()
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
            this.textBoxDestinatario.Location = new System.Drawing.Point(47, 12);
            this.textBoxDestinatario.Name = "textBoxDestinatario";
            this.textBoxDestinatario.Size = new System.Drawing.Size(334, 20);
            this.textBoxDestinatario.TabIndex = 0;
            this.textBoxDestinatario.TextChanged += new System.EventHandler(this.textBoxDestinatario_TextChanged);
            // 
            // textBoxAsunto
            // 
            this.textBoxAsunto.Location = new System.Drawing.Point(47, 38);
            this.textBoxAsunto.Name = "textBoxAsunto";
            this.textBoxAsunto.Size = new System.Drawing.Size(334, 20);
            this.textBoxAsunto.TabIndex = 1;
            // 
            // textBoxCuerpo
            // 
            this.textBoxCuerpo.Location = new System.Drawing.Point(47, 64);
            this.textBoxCuerpo.Multiline = true;
            this.textBoxCuerpo.Name = "textBoxCuerpo";
            this.textBoxCuerpo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCuerpo.Size = new System.Drawing.Size(334, 141);
            this.textBoxCuerpo.TabIndex = 2;
            // 
            // checkBoxHTML
            // 
            this.checkBoxHTML.AutoSize = true;
            this.checkBoxHTML.Location = new System.Drawing.Point(47, 239);
            this.checkBoxHTML.Name = "checkBoxHTML";
            this.checkBoxHTML.Size = new System.Drawing.Size(97, 17);
            this.checkBoxHTML.TabIndex = 3;
            this.checkBoxHTML.Text = "Formato HTML";
            this.checkBoxHTML.UseVisualStyleBackColor = true;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(306, 233);
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
            this.ClientSize = new System.Drawing.Size(470, 375);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.checkBoxHTML);
            this.Controls.Add(this.textBoxCuerpo);
            this.Controls.Add(this.textBoxAsunto);
            this.Controls.Add(this.textBoxDestinatario);
            this.Name = "Form1";
            this.Text = "Envío de correo electrónico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  
    }
}

#endregion