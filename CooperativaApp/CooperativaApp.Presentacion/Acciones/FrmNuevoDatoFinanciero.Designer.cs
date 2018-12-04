namespace CooperativaApp.Presentacion.Acciones
{
    partial class FrmNuevoDatoFinanciero
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTEA = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtITF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegDesgravamen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSegMultiriesgo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "TEA :";
            // 
            // TxtTEA
            // 
            this.TxtTEA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTEA.Location = new System.Drawing.Point(33, 40);
            this.TxtTEA.Name = "TxtTEA";
            this.TxtTEA.Size = new System.Drawing.Size(150, 27);
            this.TxtTEA.TabIndex = 29;
            this.TxtTEA.Text = "0.00";
            this.TxtTEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTEA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_Decimal);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(30, 312);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(150, 40);
            this.BtnGuardar.TabIndex = 28;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "ITF :";
            // 
            // txtITF
            // 
            this.txtITF.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITF.Location = new System.Drawing.Point(33, 97);
            this.txtITF.Name = "txtITF";
            this.txtITF.Size = new System.Drawing.Size(150, 27);
            this.txtITF.TabIndex = 37;
            this.txtITF.Text = "0.00";
            this.txtITF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtITF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_Decimal);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Seg. Desgravamen :";
            // 
            // txtSegDesgravamen
            // 
            this.txtSegDesgravamen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegDesgravamen.Location = new System.Drawing.Point(30, 156);
            this.txtSegDesgravamen.Name = "txtSegDesgravamen";
            this.txtSegDesgravamen.Size = new System.Drawing.Size(150, 27);
            this.txtSegDesgravamen.TabIndex = 35;
            this.txtSegDesgravamen.Text = "0.00";
            this.txtSegDesgravamen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSegDesgravamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_Decimal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Otros :";
            // 
            // txtOtros
            // 
            this.txtOtros.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtros.Location = new System.Drawing.Point(30, 263);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(150, 27);
            this.txtOtros.TabIndex = 39;
            this.txtOtros.Tag = "0.00";
            this.txtOtros.Text = "0.00";
            this.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_Decimal);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Seg. Multiriesgo :";
            // 
            // txtSegMultiriesgo
            // 
            this.txtSegMultiriesgo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegMultiriesgo.Location = new System.Drawing.Point(30, 212);
            this.txtSegMultiriesgo.Name = "txtSegMultiriesgo";
            this.txtSegMultiriesgo.Size = new System.Drawing.Size(150, 27);
            this.txtSegMultiriesgo.TabIndex = 41;
            this.txtSegMultiriesgo.Text = "0.00";
            this.txtSegMultiriesgo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSegMultiriesgo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_Decimal);
            // 
            // FrmNuevoDatoFinanciero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSegMultiriesgo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOtros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtITF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSegDesgravamen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTEA);
            this.Controls.Add(this.BtnGuardar);
            this.Name = "FrmNuevoDatoFinanciero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Dato Financiero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtTEA;
        public System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtITF;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtSegDesgravamen;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSegMultiriesgo;
    }
}