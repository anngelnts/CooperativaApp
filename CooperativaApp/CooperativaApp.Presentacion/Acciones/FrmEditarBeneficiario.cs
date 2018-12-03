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
    public partial class FrmEditarBeneficiario : Form
    {
        Beneficiario BeBeneficiario;
        public FrmEditarBeneficiario(Beneficiario BeBeneficiario)
        {
            InitializeComponent();
            this.BeBeneficiario = BeBeneficiario;
        }

        private void BtnBuscarSocio_Click(object sender, EventArgs e)
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
            BeBeneficiario.Id_Socio = BeSocio.Id_Socio;
            TxtNombreSocio.Text = BeSocio.Nombres;
            TxtApellidoSocio.Text = BeSocio.Apellidos;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (
                Requerido.MostrarMensaje(BeBeneficiario.Id_Beneficiario > 0, "No tiene codigo de beneficiario para Modificar.") &&
                Requerido.MostrarMensaje(BeBeneficiario.Id_Socio > 0, "No tiene codigo de socio para Modificar.") &&
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

                Be.Id_Socio = BeBeneficiario.Id_Socio;
                Be.Id_Beneficiario = BeBeneficiario.Id_Beneficiario;
                Be.Parentesco = TxtParentescoBeneficiario.Text;
                Be.Tipo_De_Documento = CmbTipoDocumentoBeneficiario.SelectedItem.ToString();
                Be.Apellidos = TxtApellidoBeneficiario.Text;
                Be.Nombres = TxtNombreBeneficiario.Text;
                Be.Tipo_De_Beneficiario = CmbTipoBeneficiario.SelectedItem.ToString();
                Be.Celular = TxtCelularBeneficiario.Text;
                Be.Telefono = TxtTelefonoBeneficiario.Text;
                Be.Num_Documento = TxtDocumentoBeneficiario.Text;
                Be.Estado = CmbEstadoBeneficiario.SelectedItem.ToString();
                Bo.Modificar(Be);
            }


        }

        private void FrmEditarBeneficiario_Load(object sender, EventArgs e)
        {
            DSocio BoSocio = new DSocio();
            TxtDocumentoSocio.Text = BoSocio.Obtener_Por_Id(BeBeneficiario.Id_Socio).Num_Documento;
            BtnBuscarSocio.PerformClick();
            TxtParentescoBeneficiario.Text = BeBeneficiario.Parentesco;
            int indiceTipoDocumento = 0;
            foreach (object Item in CmbTipoDocumentoBeneficiario.Items)
            {
                if (Item.ToString() == BeBeneficiario.Tipo_De_Documento)
                {
                    CmbTipoDocumentoBeneficiario.SelectedIndex = indiceTipoDocumento;
                }
                indiceTipoDocumento++;
            }

            TxtApellidoBeneficiario.Text = BeBeneficiario.Apellidos;
            TxtNombreBeneficiario.Text = BeBeneficiario.Nombres;
            int indiceTipoBeneficiario = 0;
            foreach (object Item in CmbTipoBeneficiario.Items) {
                if (Item.ToString() == BeBeneficiario.Tipo_De_Beneficiario) {
                    CmbTipoBeneficiario.SelectedIndex = indiceTipoBeneficiario;
                }
                indiceTipoBeneficiario++;
            }
            TxtCelularBeneficiario.Text = BeBeneficiario.Celular;
            TxtTelefonoBeneficiario.Text = BeBeneficiario.Telefono;
            TxtDocumentoBeneficiario.Text = BeBeneficiario.Num_Documento;

            int indiceEstado = 0;
            foreach (object Item in CmbEstadoBeneficiario.Items)
            {
                if (Item.ToString() == BeBeneficiario.Estado)
                {
                    CmbEstadoBeneficiario.SelectedIndex = indiceEstado;
                }
                indiceEstado++;
            }
        }
    }
}
