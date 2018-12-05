using CooperativaApp.Datos;
using CooperativaApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativaApp.Presentacion.Acciones
{
    public partial class FrmUsuarioCU : Form
    {
        public FrmUsuarioCU()
        {
            InitializeComponent();
        }

        public static int modificar = 0;
        public static int Identificador;

        public static int cbxtipousuarioselected = 0;

        public static bool BtnGE = false;

        private void FrmUsuarioCU_Load(object sender, EventArgs e)
        {
            CargarTipoUsuario();
            BtnGuardar.Enabled = BtnGE;
        }

        private void CargarTipoUsuario()
        {
            DTipoUsuario bo = new DTipoUsuario();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxTipoUsuario.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxTipoUsuario.ValueMember = "Key";
                CbxTipoUsuario.DisplayMember = "Value";
            }
            if (cbxtipousuarioselected != 0)
            {
                CbxTipoUsuario.SelectedValue = cbxtipousuarioselected;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbxTipoUsuario.Text))
            {
                MessageBox.Show("Seleccione Tipo de Usuario", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CbxTipoUsuario.Focus();
            }
            else if (string.IsNullOrEmpty(TxtUsuario.Text))
            {
                MessageBox.Show("Ingrese Usuario", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtUsuario.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingrese Nombre", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombre.Focus();
            }
            else if (string.IsNullOrEmpty(TxtApellido.Text))
            {
                MessageBox.Show("Ingrese Apellido", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtApellido.Focus();
            }
            else if (string.IsNullOrEmpty(TxtCelular.Text))
            {
                MessageBox.Show("Ingrese Celular", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCelular.Focus();
            }
            else
            {
                Guardar();
            }
        }

        private void Guardar()
        {
            Usuario be = new Usuario
            {
                Id_Usuario = Identificador,
                Id_Tipo_De_Usuario = Convert.ToInt32(CbxTipoUsuario.SelectedValue),
                Username = TxtUsuario.Text.ToLower(),
                Password = "cooperativa",
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                Celular = TxtCelular.Text,
                Estado = "Activo"
            };
            DUsuario bo = new DUsuario();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    FrmUsuarios frm = Owner as FrmUsuarios;
                    frm.Listar();
                    Close();
                    FrmPrincipal.Main.ChangeMessage("Usuario agregado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
            else if (modificar == 1)
            {
                if (bo.Modificar(be))
                {
                    FrmUsuarios frm = Owner as FrmUsuarios;
                    frm.Listar();
                    Close();
                    FrmPrincipal.Main.ChangeMessage("Usuario modificado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (ValidateEMail(TxtUsuario.Text))
            {

                if (string.IsNullOrEmpty(TxtUsuario.Text))
                {
                    BtnGuardar.Enabled = false;
                    TxtUsuario.Focus();
                }
                else
                {
                    DUsuario bo = new DUsuario();
                    if (bo.VerificarUsername(TxtUsuario.Text))
                    {
                        BtnGuardar.Enabled = true;
                        TxtUsuario.BackColor = Color.FromArgb(126, 225, 154);
                    }
                    else
                    {
                        BtnGuardar.Enabled = false;
                        TxtUsuario.BackColor = Color.FromArgb(241, 115, 117);
                        TxtUsuario.Focus();
                    }
                }
                Console.WriteLine("Correcto");
            }
            else
            {
                BtnGuardar.Enabled = false;
                TxtUsuario.BackColor = Color.FromArgb(254, 145, 72);
                TxtUsuario.Focus();
                Console.WriteLine("Incorrecto");
            }
        }
        private static bool ValidateEMail(string email)
        {
            if (email == null || email == "") return false;

            Regex oRegExp = new Regex(@"^[A-Za-z0-9_.\-]+@[A-Za-z0-9_\-]+\.([A-Za-z0-9_\-]+\.)*[A-Za-z][A-Za-z]+$", RegexOptions.IgnoreCase);
            return oRegExp.Match(email).Success;
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

    }
}
