using CooperativaApp.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativaApp.Presentacion.Acciones
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string password = TxtPasswordActual.Text;
            string newpassword = TxtPasswordNueva.Text;
            string codigo = FrmPrincipal.AccesoUsername;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Escriba su contraseña actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPasswordActual.Focus();
            }
            else if (string.IsNullOrEmpty(newpassword))
            {
                MessageBox.Show("Escriba su contraseña nueva", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPasswordNueva.Focus();
            }
            else
            {
                ChangePassword(password, newpassword, codigo);
            }
        }

        private void ChangePassword(string password, string newpassword, string codigo)
        {
            bool response = false;
            DUsuario bo = new DUsuario();
            response = bo.ChangePassword(password, newpassword, codigo);
            if (response == true)
            {
                Close();
                FrmPrincipal.Main.ChangeMessage("Contraseña cambiada correctamente", "Success");
            }
            else
            {
                FrmPrincipal.Main.ChangeMessage("Algo salio mal", "Failed");
            }
        }

        private void CheckPassword()
        {
            if (TxtPasswordNueva.Text.Equals(TxtPasswordRepeat.Text))
            {
                BtnGuardar.Enabled = true;
                TxtPasswordRepeat.BackColor = Color.FromArgb(204, 255, 144);
            }
            else
            {
                BtnGuardar.Enabled = false;
                TxtPasswordRepeat.BackColor = Color.FromArgb(255, 205, 210);
            }
        }

        private void TxtPasswordNueva_TextChanged(object sender, EventArgs e)
        {
            CheckPassword();
        }

        private void TxtPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            CheckPassword();
        }
    }
}
