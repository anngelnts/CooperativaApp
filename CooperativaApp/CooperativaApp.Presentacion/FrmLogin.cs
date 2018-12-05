using CooperativaApp.Comun;
using CooperativaApp.Datos;
using CooperativaApp.Entidades;
using MaterialSkin;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativaApp.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            //Iniciar Componentes de MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            //Agregar de Interfaz FrmLogin : MaterialForm
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue800, Primary.Blue400, Accent.Blue700, TextShade.WHITE);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void PbbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;

        private void PanelControl_MouseMove(object sender, MouseEventArgs e)
        {
            MoverFormulario(e);
        }

        private void PanelBrand_MouseMove(object sender, MouseEventArgs e)
        {
            MoverFormulario(e);
        }

        private void MoverFormulario(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsername.Text))
            {
                MessageBox.Show("Ingrese Usuario", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Ingrese Contraseña", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassword.Focus();
            }
            else
            {
                Login(TxtUsername.Text.ToLower(), TxtPassword.Text);
            }
        }
        
        private void Login(string Username, string Password)
        {
            DUsuario bo = new DUsuario();
            Usuario be = bo.LoginUsuario(Username, Password);
            if (be.Username != Username)
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrecto", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (be.Password != Password)
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrecto", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (be.Estado != "Activo")
            {
                MessageBox.Show("Usuario sin Acceso", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Registrar Token
                RegistrarToken(be.Username, DToken.GenerateToken());
                //Ingresar Token
                string respuesta = Interaction.InputBox("Ingrese Token", "Token", "", -1, -1);
                if (string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show("Ingrese Token", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Validar Token
                    if (ValidarToken(be.Username, respuesta))
                    {
                        //Obtener ID
                        FrmPrincipal.AccesoUsername = be.Username;
                        FrmPrincipal.AccesoUsernameID = be.Id_Usuario;
                        FrmPrincipal frm = new FrmPrincipal();
                        frm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Token Incorrecto", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void RegistrarToken(string Username, string Token)
        {
            Token be = new Token
            {
                Usuario = Username,
                Tokn = Token
            };
            DToken bo = new DToken();
            if (!bo.Agregar(be)) bo.Modificar(be);

            EmailHelper.Send(Username, Token);
        }

        private bool ValidarToken(string Username, string Token)
        {
            DToken bo = new DToken();
            return bo.ValidarToken(Username, Token);
        }
    }
}
