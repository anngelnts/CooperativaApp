using CooperativaApp.Datos;
using CooperativaApp.Entidades;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativaApp.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public static FrmPrincipal Main;
        //Thread
        public static bool IsInvoke = false;
        public FrmPrincipal()
        {
            InitializeComponent();
            //Instancia Estatica de Formulario Principal
            Main = this;
            //Material Skin Theme Light
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public static string AccesoUsername = "admin";
        public static int AccesoUsernameID = 1;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            BtnInicio.BackColor = Color.FromArgb(2, 136, 209);
            ChangeHeaderTitle("Dashboard");
            OpenForm(new FrmDashboard());
            FechaSistema();
            CargarPerfilBasico();

        }
        public void CargarPerfilBasico()
        {
            try
            {
                DUsuario boUsuario = new DUsuario();
                if (boUsuario.Seleccionar(AccesoUsernameID) != null)
                {
                    Usuario item = boUsuario.Seleccionar(AccesoUsernameID);
                    LblUNombre.Text = item.Nombre;
                    LblUDescripcion.Text = item.TipoUsuario;
                }
            }
            catch
            {
                Console.WriteLine("Error al obtener datos");
            }
        }
        public void OpenForm(object formulario)
        {
            if (PanelContainer.Controls.Count > 0)
            {
                PanelContainer.Controls.RemoveAt(0);
            }
            Form frm = formulario as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Size = ClientSize;
            PanelContainer.Controls.Add(frm);
            PanelContainer.Tag = frm;
            frm.Show();
        }

        public void ChangeHeaderTitle(string title)
        {
            LblHeaderTitle.Text = title;
        }

        public void MenuActive(object sender)
        {
            foreach (Control btn in PanelNavegacion.Controls)
            {
                if (btn is Button)
                {
                    btn.BackColor = Color.FromArgb(30, 34, 43);
                }
            }
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(2, 136, 209);
        }

        private void FechaSistema()
        {
            DateTime fm = DateTime.Now;
            LblFecha.Text = fm.ToLongDateString();
        }

        public void ChangeMessage(string message, string response)
        {
            LblMessage.Visible = true;
            switch (response)
            {
                case "Success":
                    PanelState.BackColor = Color.FromArgb(0, 230, 118);
                    LblMessage.ForeColor = Color.FromArgb(26, 26, 26);
                    break;
                case "Failed":
                    PanelState.BackColor = Color.FromArgb(229, 57, 53);
                    LblMessage.ForeColor = Color.White;
                    break;
                case "State":
                    PanelState.BackColor = Color.FromArgb(191, 194, 199);
                    LblMessage.ForeColor = Color.Black;
                    break;
                default:
                    LblMessage.Visible = false;
                    PanelState.BackColor = Color.FromArgb(191, 194, 199);
                    LblMessage.ForeColor = Color.Black;
                    break;
            }
            LblMessage.Text = message;
            Thread t = new Thread(new ThreadStart(MessageTheread));
            t.Start();
            IsInvoke = true;
        }

        private void MessageTheread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(500);
                if (i == 9)
                {
                    MethodInvoker setM = () => LblMessage.Visible = false;
                    MethodInvoker setP = () => PanelState.BackColor = Color.FromArgb(191, 194, 199);
                    LblMessage.BeginInvoke(setM);
                    LblMessage.BeginInvoke(setP);
                    IsInvoke = false;
                }
            }
        }

        private void PbbCerrar_Click(object sender, EventArgs e)
        {
            if (!IsInvoke)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("El Proceso del Mensaje aún no ha terminado", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = IsInvoke ? true : false;
        }

        private void PbbMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            PbbMaximizar.Visible = false;
            PbbRestaurar.Visible = true;
        }

        private void PbbRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            PbbMaximizar.Visible = true;
            PbbRestaurar.Visible = false;
        }

        private void PbbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
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

        private void PbbSalir_Click(object sender, EventArgs e)
        {
            if (!IsInvoke)
            {
                if (MessageBox.Show("¿Esta seguro de cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmLogin frm = new FrmLogin();
                    frm.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("El Proceso del Mensaje aún no ha terminado", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Modulos
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Dashboard");
            MenuActive(sender);
            OpenForm(new FrmDashboard());
        }

 
        private void PbbConfiguracion_Click(object sender, EventArgs e)
        {
            //ChangeHeaderTitle("Configuración");
            //OpenForm(new FrmConfiguracion());
        }

        private void btnDatosFinancieros_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Datos Financieros");
            MenuActive(sender);
            OpenForm(new FrmDatoFinaciero());
        }

        private void BtnSocios_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Socios");
            MenuActive(sender);
            OpenForm(new FrmSocio());
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Prestamos");
            MenuActive(sender);
            OpenForm(new FrmPrestamos());
        }

        private void BtnSimuladorDePrestamo_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Simulador De Préstamo");
            MenuActive(sender);
            OpenForm(new FrmSimuladorDePrestamo());
        }

        private void btnPagos_Click_1(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Pagos De Préstamo");
            MenuActive(sender);
            OpenForm(new FrmPago());
        }

        private void BtnEgresos_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Egresos");
            MenuActive(sender);
            OpenForm(new FrmEgresos());
        }

        private void BtnDatosCooperativa_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Datos de Cooperativa");
            MenuActive(sender);
            OpenForm(new FrmDatosCooperativa());
        }

        private void BtnBeneficiario_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Cierre de Caja");
            MenuActive(sender);
            OpenForm(new FrmCierreCaja());
        }

        private void BtnAporte_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Aportes");
            MenuActive(sender);
            OpenForm(new FrmAportes());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Usuarios");
            MenuActive(sender);
            OpenForm(new FrmUsuarios());
        }

        private void PbbPerfil_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Mi Perfil");
            OpenForm(new FrmPerfil());
        }
    }
}
