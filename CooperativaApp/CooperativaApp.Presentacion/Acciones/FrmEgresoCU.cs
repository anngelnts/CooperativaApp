using CooperativaApp.Datos;
using CooperativaApp.Entidades;
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
    public partial class FrmEgresoCU : Form
    {
        public FrmEgresoCU()
        {
            InitializeComponent();
        }

        public static int modificar = 0;
        public static int Identificador;

        private void FrmEgresoCU_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtDescripcion.Text))
            {
                MessageBox.Show("Ingrese Descripción", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDescripcion.Focus();
            }
            else if(string.IsNullOrEmpty(TxtObservacion.Text))
            {
                MessageBox.Show("Ingrese Observación", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtObservacion.Focus();
            }
            else if(string.IsNullOrEmpty(TxtMonto.Text))
            {
                MessageBox.Show("Ingrese Monto", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtMonto.Focus();
            }
            else
            {
                Guardar();
            }
        }
        private void Guardar()
        {
            Egreso be = new Egreso
            {
                Id_Egreso = Identificador,
                Descripcion = TxtDescripcion.Text,
                Observacion = TxtObservacion.Text,
                Monto = Convert.ToDouble(TxtMonto.Text),
                Estado = "Activo",
                Id_Usuario = FrmPrincipal.AccesoUsernameID
            };
            DEgreso bo = new DEgreso();
            if(modificar == 0)
            {
                if(bo.Agregar(be))
                {
                    FrmEgresos frm = Owner as FrmEgresos;
                    frm.Listar();
                    Close();
                    FrmPrincipal.Main.ChangeMessage("Egreso agregado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
            else if(modificar == 1)
            {
                if(bo.Modificar(be))
                {
                    FrmEgresos frm = Owner as FrmEgresos;
                    frm.Listar();
                    Close();
                    FrmPrincipal.Main.ChangeMessage("Egreso modificado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }

        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < TxtMonto.Text.Length; i++)
            {
                if (TxtMonto.Text[i] == ',')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 44)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
    }
}
