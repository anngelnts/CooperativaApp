using CooperativaApp.Datos;
using CooperativaApp.Entidades;
using CooperativaApp.Presentacion.Acciones;
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
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private static int IDTipoUsuario;

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            ObtenerInformacion();
            HabilitarCampos(true);
        }

        private void ObtenerInformacion()
        {
            try
            {
                DUsuario bo = new DUsuario();
                if (bo.Seleccionar(FrmPrincipal.AccesoUsernameID) == null)
                {
                    Console.WriteLine("No hay datos");
                }
                else
                {
                    Usuario item = bo.Seleccionar(FrmPrincipal.AccesoUsernameID);
                    TxtTipoUsuario.Text = item.TipoUsuario;
                    TxtUsuario.Text = item.Username;
                    TxtEstado.Text = item.Estado;
                    TxtNombres.Text = item.Nombre;
                    TxtApellidos.Text = item.Apellido;
                    TxtCelular.Text = item.Celular;
                    IDTipoUsuario = item.Id_Tipo_De_Usuario;
                }
            }
            catch
            {
                Console.WriteLine("Error al obtener datos");
            }
        }

        private void HabilitarCampos(bool x)
        {
            TxtNombres.ReadOnly = x;
            TxtApellidos.ReadOnly = x;
            TxtCelular.ReadOnly = x;
        }

        private void GuardarCambios()
        {
            Usuario be = new Usuario
            {
                Id_Usuario = FrmPrincipal.AccesoUsernameID,
                Id_Tipo_De_Usuario = IDTipoUsuario,
                Username = FrmPrincipal.AccesoUsername,
                Nombre = TxtNombres.Text,
                Apellido = TxtApellidos.Text,
                Celular = TxtCelular.Text
            };
            DUsuario bo = new DUsuario();
            if (bo.Modificar(be))
            {
                FrmPrincipal.Main.ChangeMessage("Cambios realizados correctamente", "Success");
                BtnGuardar.Enabled = false;
                BtnModificar.Enabled = true;
                HabilitarCampos(true);
                FrmPrincipal.Main.CargarPerfilBasico();
            }
            else
            {
                FrmPrincipal.Main.ChangeMessage("No se pudo realizar cambios", "Failed");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                MessageBox.Show("Ingrese Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombres.Focus();
            }
            else if (string.IsNullOrEmpty(TxtApellidos.Text))
            {
                MessageBox.Show("Ingrese Apellido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtApellidos.Focus();
            }
            else if (string.IsNullOrEmpty(TxtCelular.Text))
            {
                MessageBox.Show("Ingrese Celular", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCelular.Focus();
            }
            else
            {
                GuardarCambios();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = true;
        }

        private void BtnCambiarClave_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }
    }
}
