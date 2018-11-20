using MaterialSkin;
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
                Login(TxtUsername.Text, TxtPassword.Text);
            }
        }
        
        private void Login(string Username, string Password)
        {
            MessageBox.Show("Welcome", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
            Hide();
        }
    }
}
