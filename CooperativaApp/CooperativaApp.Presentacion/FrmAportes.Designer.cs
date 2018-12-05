namespace CooperativaApp.Presentacion
{
    partial class FrmAportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnListarTodo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtNumeroDocumentoSocioABuscar = new System.Windows.Forms.TextBox();
            this.DgvAportes = new System.Windows.Forms.DataGridView();
            this.PanelActions = new System.Windows.Forms.Panel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAportes)).BeginInit();
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
            this.BtnListarTodo.Location = new System.Drawing.Point(460, 46);
            this.BtnListarTodo.Name = "BtnListarTodo";
            this.BtnListarTodo.Size = new System.Drawing.Size(81, 27);
            this.BtnListarTodo.TabIndex = 40;
            this.BtnListarTodo.Text = "Todos";
            this.BtnListarTodo.UseVisualStyleBackColor = false;
            this.BtnListarTodo.Click += new System.EventHandler(this.BtnListarTodo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 14);
            this.label8.TabIndex = 39;
            this.label8.Text = "Búsqueda por numero de documento de socio";
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
            this.BtnBuscar.Location = new System.Drawing.Point(373, 46);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(81, 27);
            this.BtnBuscar.TabIndex = 38;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtNumeroDocumentoSocioABuscar
            // 
            this.TxtNumeroDocumentoSocioABuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumeroDocumentoSocioABuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroDocumentoSocioABuscar.Location = new System.Drawing.Point(13, 46);
            this.TxtNumeroDocumentoSocioABuscar.MaxLength = 11;
            this.TxtNumeroDocumentoSocioABuscar.Name = "TxtNumeroDocumentoSocioABuscar";
            this.TxtNumeroDocumentoSocioABuscar.Size = new System.Drawing.Size(354, 27);
            this.TxtNumeroDocumentoSocioABuscar.TabIndex = 37;
            this.TxtNumeroDocumentoSocioABuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroDocumentoSocioABuscar_KeyPress);
            // 
            // DgvAportes
            // 
            this.DgvAportes.AllowUserToAddRows = false;
            this.DgvAportes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.DgvAportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.DgvAportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAportes.BackgroundColor = System.Drawing.Color.White;
            this.DgvAportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvAportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.DgvAportes.ColumnHeadersHeight = 40;
            this.DgvAportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAportes.DefaultCellStyle = dataGridViewCellStyle19;
            this.DgvAportes.EnableHeadersVisualStyles = false;
            this.DgvAportes.GridColor = System.Drawing.Color.White;
            this.DgvAportes.Location = new System.Drawing.Point(13, 110);
            this.DgvAportes.MultiSelect = false;
            this.DgvAportes.Name = "DgvAportes";
            this.DgvAportes.ReadOnly = true;
            this.DgvAportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.DgvAportes.RowHeadersVisible = false;
            this.DgvAportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvAportes.RowTemplate.Height = 30;
            this.DgvAportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAportes.Size = new System.Drawing.Size(663, 415);
            this.DgvAportes.TabIndex = 36;
            // 
            // PanelActions
            // 
            this.PanelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.PanelActions.Controls.Add(this.BtnModificar);
            this.PanelActions.Controls.Add(this.BtnNuevo);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelActions.Location = new System.Drawing.Point(707, 0);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(200, 547);
            this.PanelActions.TabIndex = 35;
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
            // FrmAportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 547);
            this.Controls.Add(this.BtnListarTodo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtNumeroDocumentoSocioABuscar);
            this.Controls.Add(this.DgvAportes);
            this.Controls.Add(this.PanelActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAportes";
            this.Text = "FrmAportes";
            this.Load += new System.EventHandler(this.FrmAportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAportes)).EndInit();
            this.PanelActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnListarTodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtNumeroDocumentoSocioABuscar;
        private System.Windows.Forms.DataGridView DgvAportes;
        private System.Windows.Forms.Panel PanelActions;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
    }
}