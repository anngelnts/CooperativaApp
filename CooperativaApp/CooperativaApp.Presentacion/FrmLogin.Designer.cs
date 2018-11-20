namespace CooperativaApp.Presentacion
{
    partial class FrmLogin
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
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PanelBrand = new System.Windows.Forms.Panel();
            this.PanelControl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblTituloControl = new System.Windows.Forms.Label();
            this.PbbMinimizar = new System.Windows.Forms.PictureBox();
            this.PbbCerrar = new System.Windows.Forms.PictureBox();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PanelBrand.SuspendLayout();
            this.PanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBrand
            // 
            resources.ApplyResources(this.PanelBrand, "PanelBrand");
            this.PanelBrand.BackColor = System.Drawing.Color.White;
            this.PanelBrand.Controls.Add(this.PbLogo);
            this.PanelBrand.Name = "PanelBrand";
            this.PanelBrand.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBrand_MouseMove);
            // 
            // PanelControl
            // 
            resources.ApplyResources(this.PanelControl, "PanelControl");
            this.PanelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.PanelControl.Controls.Add(this.label3);
            this.PanelControl.Controls.Add(this.label2);
            this.PanelControl.Controls.Add(this.BtnLogin);
            this.PanelControl.Controls.Add(this.TxtPassword);
            this.PanelControl.Controls.Add(this.TxtUsername);
            this.PanelControl.Controls.Add(this.LblTituloControl);
            this.PanelControl.Controls.Add(this.PbbMinimizar);
            this.PanelControl.Controls.Add(this.PbbCerrar);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControl_MouseMove);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Name = "label2";
            // 
            // BtnLogin
            // 
            resources.ApplyResources(this.BtnLogin, "BtnLogin");
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Depth = 0;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLogin.Icon = null;
            this.BtnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Primary = true;
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPassword
            // 
            resources.ApplyResources(this.TxtPassword, "TxtPassword");
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Hint = "";
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.UseSystemPasswordChar = false;
            // 
            // TxtUsername
            // 
            resources.ApplyResources(this.TxtUsername, "TxtUsername");
            this.TxtUsername.Depth = 0;
            this.TxtUsername.Hint = "";
            this.TxtUsername.MaxLength = 32767;
            this.TxtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.SelectionLength = 0;
            this.TxtUsername.SelectionStart = 0;
            this.TxtUsername.TabStop = false;
            this.TxtUsername.UseSystemPasswordChar = false;
            // 
            // LblTituloControl
            // 
            resources.ApplyResources(this.LblTituloControl, "LblTituloControl");
            this.LblTituloControl.ForeColor = System.Drawing.Color.Silver;
            this.LblTituloControl.Name = "LblTituloControl";
            // 
            // PbbMinimizar
            // 
            resources.ApplyResources(this.PbbMinimizar, "PbbMinimizar");
            this.PbbMinimizar.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.icon_minimizar_light;
            this.PbbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbMinimizar.Name = "PbbMinimizar";
            this.PbbMinimizar.TabStop = false;
            this.PbbMinimizar.Click += new System.EventHandler(this.PbbMinimizar_Click);
            // 
            // PbbCerrar
            // 
            resources.ApplyResources(this.PbbCerrar, "PbbCerrar");
            this.PbbCerrar.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.icon_cerrar_light;
            this.PbbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbCerrar.Name = "PbbCerrar";
            this.PbbCerrar.TabStop = false;
            this.PbbCerrar.Click += new System.EventHandler(this.PbbCerrar_Click);
            // 
            // PbLogo
            // 
            resources.ApplyResources(this.PbLogo, "PbLogo");
            this.PbLogo.BackgroundImage = global::CooperativaApp.Presentacion.Properties.Resources.logo_cooperativa;
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.PanelBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.PanelBrand.ResumeLayout(false);
            this.PanelControl.ResumeLayout(false);
            this.PanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBrand;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton BtnLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsername;
        private System.Windows.Forms.Label LblTituloControl;
        private System.Windows.Forms.PictureBox PbbMinimizar;
        private System.Windows.Forms.PictureBox PbbCerrar;
    }
}

