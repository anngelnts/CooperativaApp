namespace CooperativaApp.Presentacion.Acciones
{
    partial class FrmEditarDatosCooperativa
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
            this.label6 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSepelioTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSepelioFamiliar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFondoSepelio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAportacion = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.BackColor = System.Drawing.Color.White;
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.DropDownWidth = 270;
            this.CmbEstado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.IntegralHeight = false;
            this.CmbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.CmbEstado.Location = new System.Drawing.Point(24, 275);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(150, 26);
            this.CmbEstado.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Seplio Titular";
            // 
            // TxtSepelioTitular
            // 
            this.TxtSepelioTitular.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSepelioTitular.Location = new System.Drawing.Point(24, 154);
            this.TxtSepelioTitular.Name = "TxtSepelioTitular";
            this.TxtSepelioTitular.Size = new System.Drawing.Size(150, 27);
            this.TxtSepelioTitular.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 62;
            this.label1.Text = "Sepelio Familiar";
            // 
            // TxtSepelioFamiliar
            // 
            this.TxtSepelioFamiliar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSepelioFamiliar.Location = new System.Drawing.Point(24, 205);
            this.TxtSepelioFamiliar.Name = "TxtSepelioFamiliar";
            this.TxtSepelioFamiliar.Size = new System.Drawing.Size(150, 27);
            this.TxtSepelioFamiliar.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "Fondo de Sepelio";
            // 
            // TxtFondoSepelio
            // 
            this.TxtFondoSepelio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFondoSepelio.Location = new System.Drawing.Point(27, 39);
            this.TxtFondoSepelio.Name = "TxtFondoSepelio";
            this.TxtFondoSepelio.Size = new System.Drawing.Size(150, 27);
            this.TxtFondoSepelio.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "Aportacion";
            // 
            // TxtAportacion
            // 
            this.TxtAportacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAportacion.Location = new System.Drawing.Point(24, 98);
            this.TxtAportacion.Name = "TxtAportacion";
            this.TxtAportacion.Size = new System.Drawing.Size(150, 27);
            this.TxtAportacion.TabIndex = 57;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(24, 317);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(150, 40);
            this.BtnModificar.TabIndex = 56;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // FrmEditarDatosCooperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 376);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSepelioTitular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSepelioFamiliar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFondoSepelio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAportacion);
            this.Controls.Add(this.BtnModificar);
            this.Name = "FrmEditarDatosCooperativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarDatosCooperativa";
            this.Load += new System.EventHandler(this.FrmEditarDatosCooperativa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtSepelioTitular;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtSepelioFamiliar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtFondoSepelio;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtAportacion;
        public System.Windows.Forms.Button BtnModificar;
    }
}