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
        public static int F_Id_Socio = 0;
        private void FrmNuevoSocio_Load(object sender, EventArgs e)
        {
            if (F_Id_Socio == 0)
            {
                cbxTipo_Documento.SelectedIndex = 1;
                cbxSexo.SelectedIndex = 0;
                cbxEstado_Civil.SelectedIndex = 0;
                cbxNivel_De_Instruccion.SelectedIndex = 1;
                cbxModalidad_De_Contratacion.SelectedIndex = 0;
                cbxCentro_De_Trabajo.SelectedIndex = 0;
                cbxEstado.SelectedIndex = 0;
                cbxNivel.SelectedIndex = 0;
            }
            else
            {
                Cargar_Datos();
            }
           
        }

        public void Cargar_Datos()
        {
            Socio beSocio = new Socio();
            DSocio boSocio = new DSocio();
            beSocio = boSocio.Obtener_Por_Id(FrmNuevoSocio.F_Id_Socio);
            
            cbxTipo_Documento.SelectedItem = beSocio.Tipo_De_Documento;
            txtNum_Documento.Text = beSocio.Num_Documento;
            txtNombres.Text = beSocio.Nombres;
            txtApellidos.Text = beSocio.Apellidos;
            txtFecha_Nacimiento.Text = beSocio.Fecha_De_Nacimiento.ToString(); ;
            cbxSexo.SelectedItem = beSocio.Sexo;
            cbxEstado_Civil.SelectedItem = beSocio.Estado_Civil;
            txtProfesion.Text = beSocio.Profesion;
            cbxNivel_De_Instruccion.SelectedItem = beSocio.Nivel_De_Instruccion;
            txtDireccion.Text = beSocio.Direccion;
            txtDistrito.Text = beSocio.Distrito;
            txtProvincia.Text = beSocio.Provincia;
            txtDepartamento.Text = beSocio.Departamento;
            txtReferencia.Text = beSocio.Referencia;
            txtCelular.Text = beSocio.Celular;
            txtEmail.Text = beSocio.Email;
            //"1" = beSocio.Envio_De_Cronogramas_De_Pago;
            txtNombreDeLaEmpresa.Text = beSocio.Nombre_De_Empresa;
            txtFecha_De_Ingreso.Text = beSocio.Fecha_De_Ingreso.ToString();
            txtIngreso_Mensual_Neto.Text = beSocio.Ingreso_Mensual_Neto.ToString();
            cbxModalidad_De_Contratacion.SelectedItem = beSocio.Modalidad_De_Contratacion;
            txtCargo.Text = beSocio.Cargo;
            cbxCentro_De_Trabajo.SelectedItem = beSocio.Centro_De_Trabajo;
            txtDireccion_Empresa.Text = beSocio.Direccion_De_Empresa;
            txtDireccion_Empresa.Text = beSocio.Distrito_De_Empresa;
            txtProvinciaEmpresa.Text = beSocio.Provincia_De_Empresa;
            txtDepartamento_Empresa.Text = beSocio.Departamento_De_Empresa;
            txtReferencia_Empresa.Text = beSocio.Referencia_De_Empresa;
            txtTelefono_Empresa.Text = beSocio.Telefono_De_Empresa;
            txtFecha_De_Registro.Text = beSocio.Fecha_De_Registro.ToString();
            txtMonto_Total_Acumulado.Text = beSocio.Monto_Acumulado.ToString();
            cbxEstado.SelectedItem = beSocio.Estado;
            cbxNivel.SelectedItem = beSocio.Nivel;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            switch (cbxTipo_Documento.SelectedItem.ToString())
            {
                case "DNI": if (txtNum_Documento.Text.Length != 8) { MessageBox.Show("El Documento Ingresado Requiere 8 Digitos."); return; } break;
                case "RUC": if (txtNum_Documento.Text.Length != 11) { MessageBox.Show("El Documento Ingresado Requiere 11 Digitos."); return; } break;
                default: MessageBox.Show("Seleccione un Tipo de Documento"); return;
                    
            }

            Socio beSocio1 = new Socio();
            Socio beSocio = new Socio();
            DSocio boSocio = new DSocio();

            beSocio1 = boSocio.Buscar_Socio_Por_Num_Documento(cbxTipo_Documento.SelectedItem.ToString(), txtNum_Documento.Text);

            if (beSocio1.Id_Socio != 0)
            {
                FrmPrincipal.Main.ChangeMessage("El Numero de documento ya se encuentra registrado.", "Failed");
                return;
            }
           
            beSocio.Id_Socio = FrmNuevoSocio.F_Id_Socio;
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

            if (F_Id_Socio == 0)
            {
                if (boSocio.Agregar(beSocio))
                {
                    FrmPrincipal.Main.ChangeMessage("Se ha Registrado Exitasamente el Socio.", "Success");
                    FrmSocio frmSocio = Owner as FrmSocio;
                    frmSocio.Listar();
                    this.Close();
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("A Ocurrido un Error.", "Failed");
                }
            }
            else
            {
                if (boSocio.Actualizar(beSocio))
                {
                    FrmPrincipal.Main.ChangeMessage("Se ha Modificado Exitasamente el Socio.", "Success");
                    FrmSocio frmSocio = Owner as FrmSocio;
                    frmSocio.Listar();
                    this.Close();
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("A Ocurrido un Error.", "Failed");
                }
            }

            


        }
    }
}
