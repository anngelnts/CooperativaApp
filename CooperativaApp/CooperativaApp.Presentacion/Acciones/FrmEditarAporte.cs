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
    public partial class FrmEditarAporte : Form
    {
        Aporte BeAporte = new Aporte();
        private int IdSocio = 0;
        private int IdDatoCooperativa = 0;

        public FrmEditarAporte(Aporte Be)
        {
            InitializeComponent();
            BeAporte = Be;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (
                Requerido.MostrarMensaje(IdSocio > 0, "Seleccione un socio para porfavor.") &&
                Requerido.MostrarMensaje(Requerido.EsEnteroValido(TxtNumeroBoleta.Text), "El numero de boleta solo debe contener digitos.") &&
                Requerido.MostrarMensaje(Requerido.EsAlfabeticoValido(TxtObservacion.Text), "La observacion solo debe contener letras.") &&
                Requerido.MostrarMensaje(TxtOtros.Text != "" || TxtOtros.Text != ",", "El apellido solo debe contener letras.")
            )
            {
                Aporte Be = new Aporte();
                DAportes Bo = new DAportes();
                
                Be.Id_Aporte = BeAporte.Id_Aporte;
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
                Bo.Modificar(Be);

            }
        }

        private void CalcularMontoTotal()
        {
            if (TxtOtros.Text != "" && TxtOtros.Text != ",")
            {
                TxtTotal.Text = (Convert.ToDecimal(TxtMontoAporte.Text) +
                            Convert.ToDecimal(TxtMontoFondoSepelio.Text) +
                            Convert.ToDecimal(TxtOtros.Text)).ToString();
            }
        }

        private void TxtOtros_TextChanged(object sender, EventArgs e)
        {
            CalcularMontoTotal();
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

        private void FrmEditarAporte_Load(object sender, EventArgs e)
        {
            Socio BeSocio = new DSocio().Obtener_Por_Id(BeAporte.Id_Socio);
            TxtDocumentoSocio.Text = BeSocio.Num_Documento;
            TxtNombreSocio.Text = BeSocio.Nombres;
            TxtApellidoSocio.Text = BeSocio.Apellidos;
            TxtNumeroBoleta.Text = BeAporte.Num_Boleta;
            TxtObservacion.Text = BeAporte.Observacion;
            IdDatoCooperativa = BeAporte.Id_Dato_Cooperativa;
            TxtMontoAporte.Text = BeAporte.Monto_Aporte.ToString();
            TxtMontoFondoSepelio.Text = BeAporte.Monto_Fondo_De_Sepelio.ToString();
            TxtOtros.Text = BeAporte.Otros.ToString();
            TxtTotal.Text = BeAporte.Monto_Total.ToString();
            int indiceEstado = 0;
            foreach (object item in CmbEstado.Items)
            {
                if (BeAporte.Estado == item.ToString())
                {
                    CmbEstado.SelectedIndex = indiceEstado;
                }
            }

            BtnBuscarSocio.PerformClick();
        }
    }
}
