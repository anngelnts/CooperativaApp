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
            cbxTipo_Documento.SelectedIndex = 0;
            cbxNum_De_Cuotas.SelectedIndex = 1;
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
            if (txtId_Socio.Text == "")
            {
                FrmPrincipal.Main.ChangeMessage("Ingrese Un Socio.", "Failed");
                return;
            }

            if (txtMonto.Text == "")
            {
                FrmPrincipal.Main.ChangeMessage("Ingrese Un Monto.", "Failed");
                return;
            }


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
            ////ESTADOS POSIBLES DE UN PRESTAMO
            ////PENDIENTE
            ////APROBADO
            ////RECHAZADO
            ////PAGADO



            ///VALIDAR PRESTAMO
            DataTable DataPrestamos = new DataTable();
            DataPrestamos = boPrestamo.Validar_Prestamo(cbxTipo_Documento.SelectedItem.ToString(), txtNum_Documento.Text);
            if (DataPrestamos.Rows.Count > 0)
            {
                MessageBox.Show("El Socio Ingresado cuenta con un prestamo pendiente.");
                return;
            }
            else
            {
                if (boPrestamo.Agregar(bePrestamo))
                {
                   
                    FrmPrestamos Frm = Owner as FrmPrestamos;
                    Frm.Listar();
                    this.Close();
                    FrmPrincipal.Main.ChangeMessage("Se ha registrado la solicitud de prestamo exitasamente.", "Success");

                }
                else
                {
                    MessageBox.Show("A Ocurrido un Error.");
                    //FrmPrincipal.Main.ChangeMessage("Ha Ocurrido un error", "Failed");
                }

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
            switch (cbxTipo_Documento.SelectedItem.ToString())
            {
                case "DNI": if (txtNum_Documento.Text.Length != 8) { FrmPrincipal.Main.ChangeMessage("El Documento Ingresado Requiere 8 Digitos.", "Failed"); return; } break;
                case "RUC": if (txtNum_Documento.Text.Length != 11) { FrmPrincipal.Main.ChangeMessage("El Documento Ingresado Requiere 11 Digitos.", "Failed"); return; } break;
                default: FrmPrincipal.Main.ChangeMessage("Seleccione un Tipo de Documento.", "Failed"); return;

            }

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
