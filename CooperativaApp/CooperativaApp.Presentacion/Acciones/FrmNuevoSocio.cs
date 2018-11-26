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
    public partial class FrmNuevoSocio : Form
    {
        public FrmNuevoSocio()
        {
            InitializeComponent();
        }

        private void FrmNuevoSocio_Load(object sender, EventArgs e)
        {
            cbxTipo_Documento.SelectedIndex = 1;
            cbxSexo.SelectedIndex = 0;
            cbxEstado_Civil.SelectedIndex = 0;
            cbxNivel_De_Instruccion.SelectedIndex = 1;
            cbxModalidad_De_Contratacion.SelectedIndex = 0;
            cbxCentro_De_Trabajo.SelectedIndex = 0;
            cbxEstado.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {


            Socio beSocio = new Socio();
            DSocio boSocio = new DSocio();
            beSocio.Tipo_De_Documento = cbxTipo_Documento.SelectedItem.ToString();
            beSocio.Num_Documento = txtNum_Documento.Text;
            beSocio.Nombres = txtNombres.Text;
            beSocio.Apellidos = txtApellidos.Text;
            beSocio.Fecha_De_Nacimiento = Convert.ToDateTime(txtFecha_Nacimiento.Text);
            beSocio.Sexo = cbxSexo.SelectedItem.ToString();
            beSocio.Estado_Civil = cbxEstado_Civil.SelectedItem.ToString();
            beSocio.Profesion = txtProfesion.Text;
            beSocio.Nivel_De_Instruccion = cbxNivel_De_Instruccion.SelectedItem.ToString();
            beSocio.Direccion = txtDireccion.Text;
            beSocio.Distrito = txtDistrito.Text;
            beSocio.Provincia = txtProvincia.Text;
            beSocio.Departamento = txtDepartamento.Text;
            beSocio.Referencia = txtReferencia.Text;
            beSocio.Celular = txtCelular.Text;
            beSocio.Email = txtEmail.Text;
            beSocio.Envio_De_Cronogramas_De_Pago = "1";
            beSocio.Nombre_De_Empresa = txtNombreDeLaEmpresa.Text;
            beSocio.Fecha_De_Ingreso = Convert.ToDateTime(txtFecha_De_Ingreso.Text);
            beSocio.Ingreso_Mensual_Neto = Convert.ToDecimal(txtIngreso_Mensual_Neto.Text);
            beSocio.Modalidad_De_Contratacion = cbxModalidad_De_Contratacion.SelectedItem.ToString();
            beSocio.Cargo = txtCargo.Text;
            beSocio.Centro_De_Trabajo = cbxCentro_De_Trabajo.SelectedItem.ToString();
            beSocio.Direccion_De_Empresa = txtDireccion_Empresa.Text;
            beSocio.Distrito_De_Empresa = txtDireccion_Empresa.Text;
            beSocio.Provincia_De_Empresa = txtProvinciaEmpresa.Text;
            beSocio.Departamento_De_Empresa = txtDepartamento_Empresa.Text;
            beSocio.Referencia_De_Empresa = txtReferencia_Empresa.Text;
            beSocio.Telefono_De_Empresa = txtTelefono_Empresa.Text;
       
            beSocio.Fecha_De_Registro = Convert.ToDateTime(txtFecha_De_Registro.Text);
            beSocio.Monto_Acumulado = Convert.ToDecimal(txtMonto_Total_Acumulado.Text);
            beSocio.Estado = cbxEstado.SelectedItem.ToString();
            beSocio.Nivel = cbxNivel.SelectedItem.ToString();

            if (boSocio.Agregar(beSocio))
            {
                MessageBox.Show("registrado");
            }
            else
            {
                MessageBox.Show("erroe");
            }


        }
    }
}
