using CooperativaApp.Datos;
using CooperativaApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativaApp.Presentacion.Acciones
{
    public partial class FrmEditarDatosCooperativa : Form
    {
        DatosDeCooperativa Be;
        public FrmEditarDatosCooperativa()
        {
            InitializeComponent();
        }

        public FrmEditarDatosCooperativa(DatosDeCooperativa Be)
        {
            InitializeComponent();
            this.Be = Be;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (
                Requerido.MostrarMensaje(Be.Id_Dato_Cooperativa > 0, "No tiene codigo para Modificar.") &&
                Requerido.MostrarMensaje(Requerido.EsDecimal(TxtAportacion.Text), "Aportacion no es valida.") &&
                Requerido.MostrarMensaje(Requerido.EsDecimal(TxtFondoSepelio.Text), "Fondo sepelio no es valida.") &&
                Requerido.MostrarMensaje(Requerido.EsDecimal(TxtSepelioTitular.Text), "Sepelio titular no es valida.") &&
                Requerido.MostrarMensaje(Requerido.EsDecimal(TxtSepelioFamiliar.Text), "Sepelio Familiar no es valida.")
                )
            {
                DDatosDeCooperativa Bo = new DDatosDeCooperativa();
                DatosDeCooperativa Be2 = new DatosDeCooperativa();
                Be2.Id_Dato_Cooperativa = this.Be.Id_Dato_Cooperativa;
                Be2.Fondo_De_Sepelio = Convert.ToDecimal(TxtFondoSepelio.Text);
                Be2.Aportacion = Convert.ToDecimal(TxtAportacion.Text);
                Be2.Sepelio_Familiar = Convert.ToDecimal(TxtSepelioFamiliar.Text);
                Be2.Sepelio_Titular = Convert.ToDecimal(TxtSepelioTitular.Text);
                Be2.Estado = CmbEstado.SelectedItem.ToString();
                if (Bo.Modificar(Be2))
                {
                    MessageBox.Show("Se modifico correctamente.");
                    FrmDatosCooperativa frm = Owner as FrmDatosCooperativa;
                    frm.Listar();
                    Close();
                }
            }


        }

        private void FrmEditarDatosCooperativa_Load(object sender, EventArgs e)
        {
            TxtFondoSepelio.Text = Be.Fondo_De_Sepelio.ToString();
            TxtAportacion.Text = Be.Aportacion.ToString();
            TxtSepelioTitular.Text = Be.Sepelio_Titular.ToString();
            TxtSepelioFamiliar.Text = Be.Sepelio_Familiar.ToString();
            int indice = 0;
            foreach (object item in CmbEstado.Items)
            {
                if (item.ToString() == Be.Estado)
                {
                    CmbEstado.SelectedIndex = indice;
                }
                indice++;
            }
        }

        private void TxtSepelioFamiliar_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtSepelioTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtAportacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtFondoSepelio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
