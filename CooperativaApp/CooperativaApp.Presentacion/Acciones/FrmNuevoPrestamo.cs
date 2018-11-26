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
    public partial class FrmNuevoPrestamo : Form
    {
        public FrmNuevoPrestamo()
        {
            InitializeComponent();
        }

        private void FrmNuevoPrestamo_Load(object sender, EventArgs e)
        {
            Dato_Financiero();
        }
        public void Dato_Financiero()
        {
            DDatoFinanciero boDatoFinanciero = new DDatoFinanciero();
            DatoFinanciero beDatoFinanciero = new DatoFinanciero();
            beDatoFinanciero = boDatoFinanciero.Dato_Financiero_Activo();
            txtId_Dato_Financiero.Text = beDatoFinanciero.Id_Dato_Financiero.ToString();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //    if (string.IsNullOrEmpty(txtMonto.Text))
            //    {
            //        MessageBox.Show("Ingrese Monto del Préstamo", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        txtMonto.Focus();
            //    }
            //    else
            //    {
            //        Guardar();
            //    }

            Prestamo bePrestamo = new Prestamo();
            DPrestamo boPrestamo = new DPrestamo();
            bePrestamo.Id_Socio = Convert.ToInt32(txtId_Socio.Text);
            bePrestamo.Id_Dato_Financiero = Convert.ToInt32(txtId_Dato_Financiero.Text);
            bePrestamo.Monto = Convert.ToDecimal(txtMonto.Text);
            bePrestamo.Num_De_Cuotas = Convert.ToInt32(cbxNum_De_Cuotas.SelectedItem);
            bePrestamo.Usuario_Sol = 1;
            bePrestamo.Usuario_Val = 1;
            bePrestamo.Estado = "PENDIENTE";
            bePrestamo.Observaciones = txtDescripcion.Text;
            bePrestamo.Anexos = "aaa";
            if(boPrestamo.Agregar(bePrestamo)){
                MessageBox.Show("registrado");
                //FrmPrincipal.Main.ChangeMessage("Préstamo agregado correctamente", "Success");

            }
            else
            {
                MessageBox.Show("error");
                //FrmPrincipal.Main.ChangeMessage("Ha Ocurrido un error", "Failed");
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtOtros_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            DSocio boSocio = new DSocio();
            Socio beSocio = new Socio();
            string Tipo_Documento = cbxTipo_Documento.SelectedItem.ToString();
            string Num_Documento = txtNum_Documento.Text;

            beSocio = boSocio.Buscar_Socio_Por_Num_Documento(Tipo_Documento,Num_Documento);
            txtNombres.Text = beSocio.Nombres;
            txtApellidos.Text = beSocio.Apellidos;
            txtCelular.Text = beSocio.Celular;
            txtEmail.Text = beSocio.Email;
            txtId_Socio.Text = beSocio.Id_Socio.ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
