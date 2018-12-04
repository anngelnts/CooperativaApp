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
    public partial class FrmNuevoAporte : Form
    {
        private int IdSocio = 0;
        private int IdDatoCooperativa = 0;
        public FrmNuevoAporte()
        {
            InitializeComponent();
        }

        private void BtnBuscarSocio_Click(object sender, EventArgs e)
        {
            if (Requerido.MostrarMensaje(Requerido.EsEnteroValido(TxtDocumentoSocio.Text, new int[] { 8, 11 }), "El Numero de documento puede ser de 8 u 11 digitos segun corresponda el tipo de documento."))
            {
                DBeneficiario BoSocio = new DBeneficiario();
                Socio BeSocio = new Socio();
                if (TxtDocumentoSocio.Text.Length == 11)
                {
                    BeSocio = BoSocio.ObtenerSocioAfiliado("RUC", TxtDocumentoSocio.Text);
                }
                if (TxtDocumentoSocio.Text.Length == 8)
                {
                    BeSocio = BoSocio.ObtenerSocioAfiliado("DNI", TxtDocumentoSocio.Text);
                }
                if (BeSocio != null)
                {
                    IdSocio = BeSocio.Id_Socio;
                    TxtNombreSocio.Text = BeSocio.Nombres;
                    TxtApellidoSocio.Text = BeSocio.Apellidos;
                }
                else
                {
                    MessageBox.Show("No se encontro un socio con este numero de documento [" + TxtDocumentoSocio.Text + "]");
                }
            }
        }

        private void CalcularMontoTotal()
        {
            if (TxtOtros.Text != ""  && TxtOtros.Text != ",")
            {
                TxtTotal.Text = (Convert.ToDecimal(TxtMontoAporte.Text) +
                            Convert.ToDecimal(TxtMontoFondoSepelio.Text) +
                            Convert.ToDecimal(TxtOtros.Text)).ToString();
            }
        }
        private void FrmNuevoAporte_Load(object sender, EventArgs e)
        {
            DDatosDeCooperativa BoDatosCooperativa = new DDatosDeCooperativa();
            DatosDeCooperativa BeDatosCooperativa = BoDatosCooperativa.ObtenerDatoCooperativaActivo();
            if (BeDatosCooperativa != null)
            {
                IdDatoCooperativa = BeDatosCooperativa.Id_Dato_Cooperativa;
                TxtMontoAporte.Text = BeDatosCooperativa.Aportacion.ToString();
                TxtMontoFondoSepelio.Text = BeDatosCooperativa.Fondo_De_Sepelio.ToString();
                CalcularMontoTotal();
            }
        }

        private void TxtOtros_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtOtros_TextChanged(object sender, EventArgs e)
        {
            CalcularMontoTotal();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (
                Requerido.MostrarMensaje(IdSocio > 0, "Seleccione un socio para porfavor.") &&
                Requerido.MostrarMensaje(Requerido.EsEnteroValido(TxtNumeroBoleta.Text), "El numero de boleta solo debe contener digitos.") &&
                Requerido.MostrarMensaje(Requerido.EsAlfabeticoValido(TxtObservacion.Text), "La observacion solo debe contener letras.") &&
                Requerido.MostrarMensaje(TxtOtros.Text != "" || TxtOtros.Text != ",", "El apellido solo debe contener letras.")
            ) {
                Aporte Be = new Aporte();
                DAportes Bo = new DAportes();
                Be.Num_Boleta = TxtNumeroBoleta.Text;
                Be.Id_Socio = IdSocio;
                Be.Observacion = TxtObservacion.Text;
                Be.Id_Dato_Cooperativa = IdDatoCooperativa;
                Be.Monto_Aporte = Convert.ToDecimal(TxtMontoAporte.Text);
                Be.Monto_Fondo_De_Sepelio = Convert.ToDecimal(TxtMontoFondoSepelio.Text);
                Be.Otros = Convert.ToDecimal(TxtOtros.Text);
                Be.Monto_Total = Convert.ToDecimal(TxtTotal.Text);
                Be.Estado = CmbEstado.SelectedItem.ToString();
                Be.Id_Usuario = FrmPrincipal.AccesoUsernameID;
                Bo.Agregar(Be);
            }


        }
    }
}
