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
    public partial class FrmNuevoBeneficiaro : Form
    {
        private int IdSocio = 0;
        public FrmNuevoBeneficiaro()
        {
            InitializeComponent();
            TxtDocumentoSocio.Text = FrmBeneficiario.NumeroDocumentoSocio;
        }


        private void CargarDatosPrincipalesSocio()
        {
            //if (Requerido.MostrarMensaje(Requerido.EsEnteroValido(TxtDocumentoSocio.Text, new int[] { 8, 11 }), "El Numero de documento puede ser de 8 u 11 digitos segun corresponda el tipo de documento."))
            //{
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
            //}
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (
                Requerido.MostrarMensaje(Requerido.EsAlfabeticoValido(TxtParentescoBeneficiario.Text), "El parentesco solo debe contener letras.") &&
                Requerido.MostrarMensaje(Requerido.EsAlfabeticoValido(TxtApellidoBeneficiario.Text), "El apellido solo debe contener letras.") &&
                Requerido.MostrarMensaje(Requerido.EsAlfabeticoValido(TxtNombreBeneficiario.Text), "El nombre solo debe contener letras.") &&
                Requerido.MostrarMensaje(Requerido.EsEnteroValido(TxtCelularBeneficiario.Text, 9), "El celular es de 9 digitos.") &&
                Requerido.MostrarMensaje(Requerido.EsEnteroValido(TxtTelefonoBeneficiario.Text, 9), "El telefono es de 9 digitos.") &&
                Requerido.MostrarMensaje(Requerido.EsEnteroValido(TxtDocumentoBeneficiario.Text, new int[] { 8, 11 }), "El Numero de documento puede ser de 8 u 11 digitos segun corresponda.")
            )
            {
                Beneficiario Be = new Beneficiario();
                DBeneficiario Bo = new DBeneficiario();
                Be.Id_Socio = IdSocio;
                Be.Parentesco = TxtParentescoBeneficiario.Text;
                Be.Tipo_De_Documento = CmbTipoDocumentoBeneficiario.SelectedItem.ToString();
                Be.Apellidos = TxtApellidoBeneficiario.Text;
                Be.Nombres = TxtNombreBeneficiario.Text;
                Be.Tipo_De_Beneficiario = CmbTipoBeneficiario.SelectedItem.ToString();
                Be.Celular = TxtCelularBeneficiario.Text;
                Be.Telefono = TxtTelefonoBeneficiario.Text;
                Be.Num_Documento = TxtDocumentoBeneficiario.Text;
                Be.Estado = CmbEstadoBeneficiario.SelectedItem.ToString();
                if (Bo.Agregar(Be))
                {
                    MessageBox.Show("Se agrego correctamente.");
                    FrmBeneficiario frm = Owner as FrmBeneficiario;
                    frm.Listar();
                    Close();
                }
            }



        }

        private void FrmNuevoBeneficiaro_Load(object sender, EventArgs e)
        {
            TxtNombreSocio.Enabled = false;
            TxtApellidoSocio.Enabled = false;
            CmbEstadoBeneficiario.SelectedIndex = 0;
            CmbTipoBeneficiario.SelectedIndex = 0;
            CmbTipoDocumentoBeneficiario.SelectedIndex = 0;
            CargarDatosPrincipalesSocio();
        }

        private void TxtDocumentoBeneficiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar)  || e.KeyChar == (Char)8)
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
