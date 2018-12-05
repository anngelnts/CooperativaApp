namespace CooperativaApp.Presentacion
{
    partial class FrmDatosCooperativa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnListarTodo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.DgvDatosCooperativa = new System.Windows.Forms.DataGridView();
            this.PanelActions = new System.Windows.Forms.Panel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosCooperativa)).BeginInit();
            this.PanelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnListarTodo
            // 
            this.BtnListarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListarTodo.BackColor = System.Drawing.Color.DimGray;
            this.BtnListarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnListarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListarTodo.FlatAppearance.BorderSize = 0;
            this.BtnListarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListarTodo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListarTodo.ForeColor = System.Drawing.Color.White;
            this.BtnListarTodo.Location = new System.Drawing.Point(289, 31);
            this.BtnListarTodo.Name = "BtnListarTodo";
            this.BtnListarTodo.Size = new System.Drawing.Size(81, 27);
            this.BtnListarTodo.TabIndex = 36;
            this.BtnListarTodo.Text = "Todos";
            this.BtnListarTodo.UseVisualStyleBackColor = false;
            this.BtnListarTodo.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 14);
            this.label8.TabIndex = 35;
            this.label8.Text = "Búsqueda por Código";
            this.label8.Visible = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.BackColor = System.Drawing.Color.Black;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(202, 31);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(81, 27);
            this.BtnBuscar.TabIndex = 34;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Visible = false;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusqueda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda.Location = new System.Drawing.Point(15, 31);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(181, 27);
            this.TxtBusqueda.TabIndex = 33;
            this.TxtBusqueda.Visible = false;
            // 
            // DgvDatosCooperativa
            // 
            this.DgvDatosCooperativa.AllowUserToAddRows = false;
            this.DgvDatosCooperativa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DgvDatosCooperativa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatosCooperativa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDatosCooperativa.BackgroundColor = System.Drawing.Color.White;
            this.DgvDatosCooperativa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatosCooperativa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvDatosCooperativa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosCooperativa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDatosCooperativa.ColumnHeadersHeight = 40;
            this.DgvDatosCooperativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosCooperativa.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDatosCooperativa.EnableHeadersVisualStyles = false;
            this.DgvDatosCooperativa.GridColor = System.Drawing.Color.White;
            this.DgvDatosCooperativa.Location = new System.Drawing.Point(15, 64);
            this.DgvDatosCooperativa.MultiSelect = false;
            this.DgvDatosCooperativa.Name = "DgvDatosCooperativa";
            this.DgvDatosCooperativa.ReadOnly = true;
            this.DgvDatosCooperativa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosCooperativa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDatosCooperativa.RowHeadersVisible = false;
            this.DgvDatosCooperativa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvDatosCooperativa.RowTemplate.Height = 30;
            this.DgvDatosCooperativa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosCooperativa.Size = new System.Drawing.Size(677, 442);
            this.DgvDatosCooperativa.TabIndex = 32;
            // 
            // PanelActions
            // 
            this.PanelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.PanelActions.Controls.Add(this.BtnModificar);
            this.PanelActions.Controls.Add(this.BtnNuevo);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelActions.Location = new System.Drawing.Point(704, 0);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(200, 518);
            this.PanelActions.TabIndex = 31;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(22, 87);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(160, 40);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(22, 41);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(160, 40);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // FrmDatosCooperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 518);
            this.Controls.Add(this.BtnListarTodo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.DgvDatosCooperativa);
            this.Controls.Add(this.PanelActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDatosCooperativa";
            this.Text = "FrmDatosCooperativa";
            this.Load += new System.EventHandler(this.FrmDatosCooperativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosCooperativa)).EndInit();
            this.PanelActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnListarTodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.DataGridView DgvDatosCooperativa;
        private System.Windows.Forms.Panel PanelActions;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
    }
}