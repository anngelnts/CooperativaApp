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
    public partial class FrmNuevoPrestamo : Form
    {
        public FrmNuevoPrestamo()
        {
            InitializeComponent();
        }

        private void FrmNuevoPrestamo_Load(object sender, EventArgs e)
        {
            //Load
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMonto.Text))
            {
                MessageBox.Show("Ingrese Monto del Préstamo", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtMonto.Focus();
            }
            else
            {
                Guardar();
            }
        }

        private void Guardar()
        {
            FrmPrestamos frm = Owner as FrmPrestamos;
            frm.Listar();
            Close();
            //Message => Success, Failed, State
            FrmPrincipal.Main.ChangeMessage("Préstamo agregado correctamente", "Success");
        }

    }
}
