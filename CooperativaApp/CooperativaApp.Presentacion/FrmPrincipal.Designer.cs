﻿namespace CooperativaApp.Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PbbMaximizar = new System.Windows.Forms.PictureBox();
            this.PbbRestaurar = new System.Windows.Forms.PictureBox();
            this.PbbMinimizar = new System.Windows.Forms.PictureBox();
            this.PbbCerrar = new System.Windows.Forms.PictureBox();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelNavegacion = new System.Windows.Forms.Panel();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnCierreCaja = new System.Windows.Forms.Button();
            this.BtnDatosCooperativa = new System.Windows.Forms.Button();
            this.btnDatosFinancieros = new System.Windows.Forms.Button();
            this.BtnEgresos = new System.Windows.Forms.Button();
            this.BtnAporte = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.BtnPrestamos = new System.Windows.Forms.Button();
            this.BtnSocios = new System.Windows.Forms.Button();
            this.BtnSimuladorDePrestamo = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelProfile = new System.Windows.Forms.Panel();
            this.PbbSalir = new System.Windows.Forms.PictureBox();
            this.PbbPerfil = new System.Windows.Forms.PictureBox();
            this.PbbConfiguracion = new System.Windows.Forms.PictureBox();
            this.LblUDescripcion = new System.Windows.Forms.Label();
            this.LblUNombre = new System.Windows.Forms.Label();
            this.PbxUFoto = new System.Windows.Forms.PictureBox();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHeaderTitle = new System.Windows.Forms.Label();
            this.PanelState = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbCerrar)).BeginInit();
            this.PanelLeft.SuspendLayout();
            this.PanelNavegacion.SuspendLayout();
            this.PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUFoto)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelState.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Black;
            this.PanelTop.Controls.Add(this.PbLogo);
            this.PanelTop.Controls.Add(this.PbbMaximizar);
            this.PanelTop.Controls.Add(this.PbbRestaurar);
            this.PanelTop.Controls.Add(this.PbbMinimizar);
            this.PanelTop.Controls.Add(this.PbbCerrar);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1300, 45);
            this.PanelTop.TabIndex = 1;
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            // 
            // PbLogo
            // 
            this.PbLogo.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.logo_coop;
            this.PbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbLogo.Location = new System.Drawing.Point(6, 5);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(45, 35);
            this.PbLogo.TabIndex = 4;
            this.PbLogo.TabStop = false;
            // 
            // PbbMaximizar
            // 
            this.PbbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbMaximizar.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.icon_maximizar_light;
            this.PbbMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbMaximizar.Location = new System.Drawing.Point(1221, 5);
            this.PbbMaximizar.Name = "PbbMaximizar";
            this.PbbMaximizar.Size = new System.Drawing.Size(35, 35);
            this.PbbMaximizar.TabIndex = 1;
            this.PbbMaximizar.TabStop = false;
            this.PbbMaximizar.Click += new System.EventHandler(this.PbbMaximizar_Click);
            // 
            // PbbRestaurar
            // 
            this.PbbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbRestaurar.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.icon_restaurar_light;
            this.PbbRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbRestaurar.Location = new System.Drawing.Point(1221, 5);
            this.PbbRestaurar.Name = "PbbRestaurar";
            this.PbbRestaurar.Size = new System.Drawing.Size(35, 35);
            this.PbbRestaurar.TabIndex = 2;
            this.PbbRestaurar.TabStop = false;
            this.PbbRestaurar.Click += new System.EventHandler(this.PbbRestaurar_Click);
            // 
            // PbbMinimizar
            // 
            this.PbbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbMinimizar.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.icon_minimizar_light;
            this.PbbMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbMinimizar.Location = new System.Drawing.Point(1183, 5);
            this.PbbMinimizar.Name = "PbbMinimizar";
            this.PbbMinimizar.Size = new System.Drawing.Size(35, 35);
            this.PbbMinimizar.TabIndex = 3;
            this.PbbMinimizar.TabStop = false;
            this.PbbMinimizar.Click += new System.EventHandler(this.PbbMinimizar_Click);
            // 
            // PbbCerrar
            // 
            this.PbbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbCerrar.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.icon_cerrar_light;
            this.PbbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbCerrar.Location = new System.Drawing.Point(1259, 5);
            this.PbbCerrar.Name = "PbbCerrar";
            this.PbbCerrar.Size = new System.Drawing.Size(35, 35);
            this.PbbCerrar.TabIndex = 0;
            this.PbbCerrar.TabStop = false;
            this.PbbCerrar.Click += new System.EventHandler(this.PbbCerrar_Click);
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.PanelLeft.Controls.Add(this.PanelNavegacion);
            this.PanelLeft.Controls.Add(this.PanelProfile);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 45);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(250, 655);
            this.PanelLeft.TabIndex = 2;
            // 
            // PanelNavegacion
            // 
            this.PanelNavegacion.AutoScroll = true;
            this.PanelNavegacion.Controls.Add(this.BtnUsuarios);
            this.PanelNavegacion.Controls.Add(this.BtnCierreCaja);
            this.PanelNavegacion.Controls.Add(this.BtnDatosCooperativa);
            this.PanelNavegacion.Controls.Add(this.btnDatosFinancieros);
            this.PanelNavegacion.Controls.Add(this.BtnEgresos);
            this.PanelNavegacion.Controls.Add(this.BtnAporte);
            this.PanelNavegacion.Controls.Add(this.btnPagos);
            this.PanelNavegacion.Controls.Add(this.BtnPrestamos);
            this.PanelNavegacion.Controls.Add(this.BtnSocios);
            this.PanelNavegacion.Controls.Add(this.BtnSimuladorDePrestamo);
            this.PanelNavegacion.Controls.Add(this.BtnInicio);
            this.PanelNavegacion.Controls.Add(this.label4);
            this.PanelNavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNavegacion.Location = new System.Drawing.Point(0, 130);
            this.PanelNavegacion.Name = "PanelNavegacion";
            this.PanelNavegacion.Size = new System.Drawing.Size(250, 525);
            this.PanelNavegacion.TabIndex = 2;
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.Color.White;
            this.BtnUsuarios.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_usuarios_light;
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.Location = new System.Drawing.Point(-6, 600);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnUsuarios.Size = new System.Drawing.Size(250, 50);
            this.BtnUsuarios.TabIndex = 15;
            this.BtnUsuarios.Text = "  Usuarios";
            this.BtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnCierreCaja
            // 
            this.BtnCierreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCierreCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnCierreCaja.FlatAppearance.BorderSize = 0;
            this.BtnCierreCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnCierreCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.BtnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCierreCaja.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCierreCaja.ForeColor = System.Drawing.Color.White;
            this.BtnCierreCaja.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_datos_light;
            this.BtnCierreCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCierreCaja.Location = new System.Drawing.Point(-6, 544);
            this.BtnCierreCaja.Name = "BtnCierreCaja";
            this.BtnCierreCaja.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCierreCaja.Size = new System.Drawing.Size(250, 50);
            this.BtnCierreCaja.TabIndex = 14;
            this.BtnCierreCaja.Text = "  Cierre de Caja";
            this.BtnCierreCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCierreCaja.UseVisualStyleBackColor = true;
            this.BtnCierreCaja.Click += new System.EventHandler(this.BtnBeneficiario_Click);
            // 
            // BtnDatosCooperativa
            // 
            this.BtnDatosCooperativa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDatosCooperativa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnDatosCooperativa.FlatAppearance.BorderSize = 0;
            this.BtnDatosCooperativa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnDatosCooperativa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.BtnDatosCooperativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDatosCooperativa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDatosCooperativa.ForeColor = System.Drawing.Color.White;
            this.BtnDatosCooperativa.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_datos_light;
            this.BtnDatosCooperativa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDatosCooperativa.Location = new System.Drawing.Point(-6, 488);
            this.BtnDatosCooperativa.Name = "BtnDatosCooperativa";
            this.BtnDatosCooperativa.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnDatosCooperativa.Size = new System.Drawing.Size(250, 50);
            this.BtnDatosCooperativa.TabIndex = 13;
            this.BtnDatosCooperativa.Text = "  Datos Cooperativa";
            this.BtnDatosCooperativa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDatosCooperativa.UseVisualStyleBackColor = true;
            this.BtnDatosCooperativa.Click += new System.EventHandler(this.BtnDatosCooperativa_Click);
            // 
            // btnDatosFinancieros
            // 
            this.btnDatosFinancieros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatosFinancieros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnDatosFinancieros.FlatAppearance.BorderSize = 0;
            this.btnDatosFinancieros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnDatosFinancieros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnDatosFinancieros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosFinancieros.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosFinancieros.ForeColor = System.Drawing.Color.White;
            this.btnDatosFinancieros.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_datos_light;
            this.btnDatosFinancieros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatosFinancieros.Location = new System.Drawing.Point(-6, 432);
            this.btnDatosFinancieros.Name = "btnDatosFinancieros";
            this.btnDatosFinancieros.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDatosFinancieros.Size = new System.Drawing.Size(250, 50);
            this.btnDatosFinancieros.TabIndex = 12;
            this.btnDatosFinancieros.Text = "  Datos Financieros";
            this.btnDatosFinancieros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatosFinancieros.UseVisualStyleBackColor = true;
            this.btnDatosFinancieros.Click += new System.EventHandler(this.btnDatosFinancieros_Click);
            // 
            // BtnEgresos
            // 
            this.BtnEgresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEgresos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnEgresos.FlatAppearance.BorderSize = 0;
            this.BtnEgresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnEgresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.BtnEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEgresos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEgresos.ForeColor = System.Drawing.Color.White;
            this.BtnEgresos.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_egreso_light;
            this.BtnEgresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEgresos.Location = new System.Drawing.Point(-6, 376);
            this.BtnEgresos.Name = "BtnEgresos";
            this.BtnEgresos.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnEgresos.Size = new System.Drawing.Size(250, 50);
            this.BtnEgresos.TabIndex = 11;
            this.BtnEgresos.Text = "  Egresos";
            this.BtnEgresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEgresos.UseVisualStyleBackColor = true;
            this.BtnEgresos.Click += new System.EventHandler(this.BtnEgresos_Click);
            // 
            // BtnAporte
            // 
            this.BtnAporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnAporte.FlatAppearance.BorderSize = 0;
            this.BtnAporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnAporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.BtnAporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAporte.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAporte.ForeColor = System.Drawing.Color.White;
            this.BtnAporte.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_aportes_light;
            this.BtnAporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAporte.Location = new System.Drawing.Point(0, 320);
            this.BtnAporte.Name = "BtnAporte";
            this.BtnAporte.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAporte.Size = new System.Drawing.Size(250, 50);
            this.BtnAporte.TabIndex = 9;
            this.BtnAporte.Text = "  Aportes";
            this.BtnAporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAporte.UseVisualStyleBackColor = true;
            this.BtnAporte.Click += new System.EventHandler(this.BtnAporte_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_h_pagos_light;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(0, 264);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPagos.Size = new System.Drawing.Size(250, 50);
            this.btnPagos.TabIndex = 8;
            this.btnPagos.Text = "  Pagos";
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click_1);
            // 
            // BtnPrestamos
            // 
            this.BtnPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnPrestamos.FlatAppearance.BorderSize = 0;
            this.BtnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.BtnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrestamos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrestamos.ForeColor = System.Drawing.Color.White;
            this.BtnPrestamos.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_prestamo_light;
            this.BtnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrestamos.Location = new System.Drawing.Point(0, 208);
            this.BtnPrestamos.Name = "BtnPrestamos";
            this.BtnPrestamos.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnPrestamos.Size = new System.Drawing.Size(250, 50);
            this.BtnPrestamos.TabIndex = 7;
            this.BtnPrestamos.Text = "  Prestamos";
            this.BtnPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrestamos.UseVisualStyleBackColor = true;
            this.BtnPrestamos.Click += new System.EventHandler(this.BtnPagos_Click);
            // 
            // BtnSocios
            // 
            this.BtnSocios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSocios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnSocios.FlatAppearance.BorderSize = 0;
            this.BtnSocios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnSocios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.BtnSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSocios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSocios.ForeColor = System.Drawing.Color.White;
            this.BtnSocios.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_socio_light;
            this.BtnSocios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSocios.Location = new System.Drawing.Point(0, 152);
            this.BtnSocios.Name = "BtnSocios";
            this.BtnSocios.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnSocios.Size = new System.Drawing.Size(250, 50);
            this.BtnSocios.TabIndex = 6;
            this.BtnSocios.Text = "  Socios";
            this.BtnSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSocios.UseVisualStyleBackColor = true;
            this.BtnSocios.Click += new System.EventHandler(this.BtnSocios_Click);
            // 
            // BtnSimuladorDePrestamo
            // 
            this.BtnSimuladorDePrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSimuladorDePrestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnSimuladorDePrestamo.FlatAppearance.BorderSize = 0;
            this.BtnSimuladorDePrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnSimuladorDePrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.BtnSimuladorDePrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimuladorDePrestamo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimuladorDePrestamo.ForeColor = System.Drawing.Color.White;
            this.BtnSimuladorDePrestamo.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_prestamo_light;
            this.BtnSimuladorDePrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSimuladorDePrestamo.Location = new System.Drawing.Point(0, 96);
            this.BtnSimuladorDePrestamo.Name = "BtnSimuladorDePrestamo";
            this.BtnSimuladorDePrestamo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnSimuladorDePrestamo.Size = new System.Drawing.Size(250, 50);
            this.BtnSimuladorDePrestamo.TabIndex = 5;
            this.BtnSimuladorDePrestamo.Text = "  Simulador De Préstamo";
            this.BtnSimuladorDePrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSimuladorDePrestamo.UseVisualStyleBackColor = true;
            this.BtnSimuladorDePrestamo.Click += new System.EventHandler(this.BtnSimuladorDePrestamo_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.White;
            this.BtnInicio.Image = global::CooperativaApp.Presentacion.Properties.Resources.icon_xs_home_light;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(0, 40);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnInicio.Size = new System.Drawing.Size(250, 50);
            this.BtnInicio.TabIndex = 4;
            this.BtnInicio.Text = "  Inicio";
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NAVEGACIÓN PRINCIPAL";
            // 
            // PanelProfile
            // 
            this.PanelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.PanelProfile.Controls.Add(this.PbbSalir);
            this.PanelProfile.Controls.Add(this.PbbPerfil);
            this.PanelProfile.Controls.Add(this.PbbConfiguracion);
            this.PanelProfile.Controls.Add(this.LblUDescripcion);
            this.PanelProfile.Controls.Add(this.LblUNombre);
            this.PanelProfile.Controls.Add(this.PbxUFoto);
            this.PanelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProfile.Location = new System.Drawing.Point(0, 0);
            this.PanelProfile.Name = "PanelProfile";
            this.PanelProfile.Size = new System.Drawing.Size(250, 130);
            this.PanelProfile.TabIndex = 1;
            // 
            // PbbSalir
            // 
            this.PbbSalir.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.icon_salir_light;
            this.PbbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbSalir.Location = new System.Drawing.Point(165, 96);
            this.PbbSalir.Name = "PbbSalir";
            this.PbbSalir.Size = new System.Drawing.Size(25, 25);
            this.PbbSalir.TabIndex = 5;
            this.PbbSalir.TabStop = false;
            this.PbbSalir.Click += new System.EventHandler(this.PbbSalir_Click);
            // 
            // PbbPerfil
            // 
            this.PbbPerfil.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.icon_user_light;
            this.PbbPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbPerfil.Location = new System.Drawing.Point(113, 96);
            this.PbbPerfil.Name = "PbbPerfil";
            this.PbbPerfil.Size = new System.Drawing.Size(25, 25);
            this.PbbPerfil.TabIndex = 4;
            this.PbbPerfil.TabStop = false;
            this.PbbPerfil.Click += new System.EventHandler(this.PbbPerfil_Click);
            // 
            // PbbConfiguracion
            // 
            this.PbbConfiguracion.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.icon_setting_light;
            this.PbbConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbConfiguracion.Location = new System.Drawing.Point(62, 96);
            this.PbbConfiguracion.Name = "PbbConfiguracion";
            this.PbbConfiguracion.Size = new System.Drawing.Size(25, 25);
            this.PbbConfiguracion.TabIndex = 3;
            this.PbbConfiguracion.TabStop = false;
            this.PbbConfiguracion.Click += new System.EventHandler(this.PbbConfiguracion_Click);
            // 
            // LblUDescripcion
            // 
            this.LblUDescripcion.AutoSize = true;
            this.LblUDescripcion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.LblUDescripcion.Location = new System.Drawing.Point(78, 48);
            this.LblUDescripcion.Name = "LblUDescripcion";
            this.LblUDescripcion.Size = new System.Drawing.Size(111, 18);
            this.LblUDescripcion.TabIndex = 2;
            this.LblUDescripcion.Text = "Administrador";
            // 
            // LblUNombre
            // 
            this.LblUNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUNombre.ForeColor = System.Drawing.Color.White;
            this.LblUNombre.Location = new System.Drawing.Point(78, 24);
            this.LblUNombre.Name = "LblUNombre";
            this.LblUNombre.Size = new System.Drawing.Size(158, 18);
            this.LblUNombre.TabIndex = 1;
            this.LblUNombre.Text = "Luis Angel Moreno";
            // 
            // PbxUFoto
            // 
            this.PbxUFoto.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.profile;
            this.PbxUFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxUFoto.Location = new System.Drawing.Point(12, 15);
            this.PbxUFoto.Name = "PbxUFoto";
            this.PbxUFoto.Size = new System.Drawing.Size(60, 60);
            this.PbxUFoto.TabIndex = 0;
            this.PbxUFoto.TabStop = false;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.White;
            this.PanelHeader.Controls.Add(this.LblFecha);
            this.PanelHeader.Controls.Add(this.LblHeaderTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(250, 45);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1050, 50);
            this.PanelHeader.TabIndex = 3;
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(671, 14);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblFecha.Size = new System.Drawing.Size(367, 18);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Lunes, 19 de Noviembre del 2018";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblHeaderTitle
            // 
            this.LblHeaderTitle.AutoSize = true;
            this.LblHeaderTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.LblHeaderTitle.Location = new System.Drawing.Point(16, 14);
            this.LblHeaderTitle.Name = "LblHeaderTitle";
            this.LblHeaderTitle.Size = new System.Drawing.Size(125, 23);
            this.LblHeaderTitle.TabIndex = 0;
            this.LblHeaderTitle.Text = "Dashboard";
            // 
            // PanelState
            // 
            this.PanelState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.PanelState.Controls.Add(this.LblMessage);
            this.PanelState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelState.Location = new System.Drawing.Point(250, 660);
            this.PanelState.Name = "PanelState";
            this.PanelState.Size = new System.Drawing.Size(1050, 40);
            this.PanelState.TabIndex = 4;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(17, 11);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(26, 18);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "...";
            this.LblMessage.Visible = false;
            // 
            // PanelContainer
            // 
            this.PanelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(250, 95);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1050, 565);
            this.PanelContainer.TabIndex = 5;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.PanelState);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cooperativa de Ahorro y Crédito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbCerrar)).EndInit();
            this.PanelLeft.ResumeLayout(false);
            this.PanelNavegacion.ResumeLayout(false);
            this.PanelNavegacion.PerformLayout();
            this.PanelProfile.ResumeLayout(false);
            this.PanelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUFoto)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelState.ResumeLayout(false);
            this.PanelState.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.PictureBox PbbMaximizar;
        private System.Windows.Forms.PictureBox PbbRestaurar;
        private System.Windows.Forms.PictureBox PbbMinimizar;
        private System.Windows.Forms.PictureBox PbbCerrar;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelProfile;
        private System.Windows.Forms.PictureBox PbbSalir;
        private System.Windows.Forms.PictureBox PbbPerfil;
        private System.Windows.Forms.PictureBox PbbConfiguracion;
        private System.Windows.Forms.Label LblUDescripcion;
        private System.Windows.Forms.Label LblUNombre;
        private System.Windows.Forms.PictureBox PbxUFoto;
        private System.Windows.Forms.Panel PanelNavegacion;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSocios;
        private System.Windows.Forms.Button BtnSimuladorDePrestamo;
        private System.Windows.Forms.Button BtnPrestamos;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHeaderTitle;
        private System.Windows.Forms.Panel PanelState;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Button BtnEgresos;
        private System.Windows.Forms.Button BtnAporte;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnDatosFinancieros;
        private System.Windows.Forms.Button BtnDatosCooperativa;
        private System.Windows.Forms.Button BtnCierreCaja;
        private System.Windows.Forms.Button BtnUsuarios;
    }
}