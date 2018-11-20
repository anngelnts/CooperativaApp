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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            BtnInicio.BackColor = Color.FromArgb(2, 136, 209);
            ChangeHeaderTitle("Dashboard");
            OpenForm(new FrmDashboard());
            FechaSistema();
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

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Préstamos");
            MenuActive(sender);
            OpenForm(new FrmPrestamos());
        }
    }
}
