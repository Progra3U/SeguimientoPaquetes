namespace _01Presentacion
{
    partial class Usuario
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
            this.lblMensajeUsuario = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensajeUsuario
            // 
            this.lblMensajeUsuario.AutoSize = true;
            this.lblMensajeUsuario.Location = new System.Drawing.Point(76, 80);
            this.lblMensajeUsuario.Name = "lblMensajeUsuario";
            this.lblMensajeUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblMensajeUsuario.TabIndex = 0;
            this.lblMensajeUsuario.Text = "label1";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(125, 124);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblTipoUsuario.TabIndex = 1;
            this.lblTipoUsuario.Text = "Usuario";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblMensajeUsuario);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensajeUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
    }
}