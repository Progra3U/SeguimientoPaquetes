namespace _01Presentacion
{
    partial class Cliente_DoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente_DoPedido));
            this.icono = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.comboPago = new System.Windows.Forms.ComboBox();
            this.comboEnvio = new System.Windows.Forms.ComboBox();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.comboOrigen = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdEstado = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // icono
            // 
            this.icono.Image = ((System.Drawing.Image)(resources.GetObject("icono.Image")));
            this.icono.Location = new System.Drawing.Point(12, 4);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(25, 25);
            this.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono.TabIndex = 1;
            this.icono.TabStop = false;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCentral.Controls.Add(this.comboPago);
            this.panelCentral.Controls.Add(this.comboEnvio);
            this.panelCentral.Controls.Add(this.comboDestino);
            this.panelCentral.Controls.Add(this.comboOrigen);
            this.panelCentral.Controls.Add(this.txtTotal);
            this.panelCentral.Controls.Add(this.txtDescripcion);
            this.panelCentral.Controls.Add(this.txtIdEstado);
            this.panelCentral.Controls.Add(this.txtIdUsuario);
            this.panelCentral.Controls.Add(this.label9);
            this.panelCentral.Controls.Add(this.label8);
            this.panelCentral.Controls.Add(this.label7);
            this.panelCentral.Controls.Add(this.label5);
            this.panelCentral.Controls.Add(this.label4);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Controls.Add(this.txtIdPedido);
            this.panelCentral.Controls.Add(this.label6);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 35);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(520, 320);
            this.panelCentral.TabIndex = 9;
            // 
            // comboPago
            // 
            this.comboPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPago.FormattingEnabled = true;
            this.comboPago.Items.AddRange(new object[] {
            "TERRESTRE",
            "MARITIMO",
            "AEREO"});
            this.comboPago.Location = new System.Drawing.Point(98, 122);
            this.comboPago.Name = "comboPago";
            this.comboPago.Size = new System.Drawing.Size(181, 28);
            this.comboPago.TabIndex = 69;
            // 
            // comboEnvio
            // 
            this.comboEnvio.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEnvio.FormattingEnabled = true;
            this.comboEnvio.Items.AddRange(new object[] {
            "TARJETA CREDITO",
            "TARJETA DEBITO",
            "EFECTIVO"});
            this.comboEnvio.Location = new System.Drawing.Point(299, 122);
            this.comboEnvio.Name = "comboEnvio";
            this.comboEnvio.Size = new System.Drawing.Size(181, 28);
            this.comboEnvio.TabIndex = 67;
            // 
            // comboDestino
            // 
            this.comboDestino.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Items.AddRange(new object[] {
            "Alabama (AL)"});
            this.comboDestino.Location = new System.Drawing.Point(98, 70);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(382, 28);
            this.comboDestino.TabIndex = 65;
            // 
            // comboOrigen
            // 
            this.comboOrigen.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOrigen.FormattingEnabled = true;
            this.comboOrigen.Items.AddRange(new object[] {
            "Alabama (AL)"});
            this.comboOrigen.Location = new System.Drawing.Point(98, 37);
            this.comboOrigen.Name = "comboOrigen";
            this.comboOrigen.Size = new System.Drawing.Size(382, 28);
            this.comboOrigen.TabIndex = 64;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(344, 228);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(136, 27);
            this.txtTotal.TabIndex = 63;
            this.txtTotal.Text = "5000";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(16, 185);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(464, 27);
            this.txtDescripcion.TabIndex = 59;
            // 
            // txtIdEstado
            // 
            this.txtIdEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEstado.Location = new System.Drawing.Point(177, 269);
            this.txtIdEstado.Name = "txtIdEstado";
            this.txtIdEstado.ReadOnly = true;
            this.txtIdEstado.Size = new System.Drawing.Size(303, 27);
            this.txtIdEstado.TabIndex = 58;
            this.txtIdEstado.Text = "PROCESANDO";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(98, 4);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(137, 27);
            this.txtIdUsuario.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Desc Pedido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Id Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Origen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tipo Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "tipo Envio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Estado del pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Total:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPedido.Location = new System.Drawing.Point(112, 228);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.ReadOnly = true;
            this.txtIdPedido.Size = new System.Drawing.Size(137, 27);
            this.txtIdPedido.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Pedido  #:";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BarraTitulo.Controls.Add(this.icono);
            this.BarraTitulo.Controls.Add(this.btnGuardar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(520, 35);
            this.BarraTitulo.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(483, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(25, 25);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Cliente_DoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 355);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente_DoPedido";
            this.Text = "Usuario_DoPedido";
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdEstado;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboEnvio;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.ComboBox comboOrigen;
        private System.Windows.Forms.ComboBox comboPago;
    }
}