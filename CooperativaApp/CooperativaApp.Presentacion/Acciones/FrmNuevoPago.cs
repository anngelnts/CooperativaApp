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
    public partial class FrmNuevoPago : Form
    {
        public FrmNuevoPago()
        {
            InitializeComponent();
        }

        private void btnBuscarPagos_Click(object sender, EventArgs e)
        {
            DCronogramaDePagos boCronogramaDePagos = new DCronogramaDePagos();
            string Tipo_De_Documento = cbxTipo_Documento.SelectedItem.ToString();
            string Num_Documento = txtNum_Documento.Text;
            switch (cbxTipo_Documento.SelectedItem.ToString())
            {
                case "DNI": if (txtNum_Documento.Text.Length != 8) { MessageBox.Show("El Documento Ingresado Requiere 8 Digitos."); return; } break;
                case "RUC": if (txtNum_Documento.Text.Length != 11) { MessageBox.Show("El Documento Ingresado Requiere 11 Digitos."); return; } break;
                default: MessageBox.Show("Seleccione un Tipo de Documento"); return;

            }

            /////TRAER DATOS DE SOCIO
            DSocio boSocio = new DSocio();
            Socio beSocio = new Socio();
            beSocio = boSocio.Buscar_Socio_Por_Num_Documento(Tipo_De_Documento, Num_Documento);
            
     
            if (beSocio.Id_Socio.ToString() != "")
            {
                txtNombres.Text = beSocio.Apellidos + " " + beSocio.Nombres;
            }
            else
            {
                txtNombres.Text = "";
            }

            DgvCronogramaDePago.Rows.Clear();
            DgvCronogramaDePago.ColumnCount = 13;

            ////TRAER PAGOS PENDIENNES
            foreach (DataRow var in boCronogramaDePagos.ObtenerPagosPendientes(Tipo_De_Documento, Num_Documento).Rows)
            {
                DgvCronogramaDePago.Rows.Add(
                   var[0].ToString(),
                   var[1].ToString(),
                   var["Num_Cuota"].ToString(),
                   Convert.ToDateTime(var["Fecha_De_Vencimiento"]).ToString("dd/MM/yyyy"),
                   var["Amortizacion"].ToString(),
                   var["Interes"].ToString(),
                   var["Interes_Diferido"].ToString(),
                   var["Seg_Desgravamen"].ToString(),
                   var["Seg_Multiriesgo"].ToString(),
                   var["ITF"].ToString(),
                   var["Otros"].ToString(),
                   var["Saldo_Capital"].ToString(),
                   var["Cuota_Fija"].ToString()
                   );

            }
        }

        private void FrmNuevoPago_Load(object sender, EventArgs e)
        {
            cbxTipo_Documento.SelectedIndex = 0;
            cbxTipo_De_Pago.SelectedIndex = 0;
        }

        private void Obtener_Cronogrma_De_Pago(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (DgvCronogramaDePago.Rows[indice].Cells[0].Value.ToString() != "")
            {
                CronogramaDePagos beCronograma = new CronogramaDePagos();
                DCronogramaDePagos boCronograma = new DCronogramaDePagos();

                DataTable data = boCronograma.Seleccionar(Convert.ToInt32(DgvCronogramaDePago.Rows[indice].Cells[0].Value));

                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    txtId_Cronograma_De_Pago.Text = row["Id_Cronograma"].ToString();
                    txtNum_Couta.Text = row["Num_Cuota"].ToString();
                    txtFecha_Vencimiento.Text = (row["Fecha_De_Vencimiento"]).ToString();
                    txtAmoritzacion.Text = row["Amortizacion"].ToString();
                    txtInteres.Text = row["Interes"].ToString();
                    txtInteres_Diferido.Text = row["Interes_Diferido"].ToString();
                    txtSeg_Desgravamen.Text = row["Seg_Desgravamen"].ToString();
                    txtSeg_Multiriesgo.Text = row["Seg_Multiriesgo"].ToString();
                    txtITF.Text = row["ITF"].ToString();
                    txtOtros.Text = row["Otros"].ToString();
                    txtCouta_Fija.Text = row["Cuota_Fija"].ToString();
                    txtId_Prestamo.Text = row["Id_Prestamo"].ToString();
                    txtTotal_Pagado.Text = row["Cuota_Fija"].ToString();


                }
            }
            else
            {
                MessageBox.Show("Seleccione una Cuota");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Pago bePago = new Pago();
            DPago boPago = new DPago();


            bePago.Num_Boleta = txtNum_Recibo.Text;
            bePago.Id_Cronograma = Convert.ToInt32(txtId_Cronograma_De_Pago.Text);
            bePago.Observacion = txtObservacion.Text;
            bePago.Tipo_De_Pago = cbxTipo_De_Pago.SelectedItem.ToString();
            bePago.Cuota_Fija = Convert.ToDecimal(txtCouta_Fija.Text);
            bePago.Dias_Morosidad = Convert.ToDecimal(txtDias_Morosidad.Text);
            bePago.Monto_Morosidad = Convert.ToDecimal(txtMora.Text);
            bePago.Monto_Total = Convert.ToDecimal(txtTotal_Pagado.Text);
            bePago.Id_Usuario = 1;
            bePago.Estado = "PAGADO";
            if (boPago.Agregar(bePago))
            {
                CronogramaDePagos beCronograma = new CronogramaDePagos();
                DCronogramaDePagos boCronograma = new DCronogramaDePagos();

                beCronograma.Id_Cronograma = Convert.ToInt32(txtId_Cronograma_De_Pago.Text);
                beCronograma.Dias_Morosidad = Convert.ToInt32(txtDias_Morosidad.Text);
                beCronograma.Monto_Morosidad = Convert.ToDecimal(txtMora.Text);
                beCronograma.Cuota_Total = Convert.ToDecimal(txtTotal_Pagado.Text);
                beCronograma.Estado = "PAGADO";
                beCronograma.Fecha_De_Pago = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                if (boCronograma.Actualizar(beCronograma))
                {
                    FrmPago Frm = Owner as FrmPago;
                    Frm.Listar();
                    this.Close();
                    FrmPrincipal.Main.ChangeMessage("Se ha registrado el pago  exitasamente.", "Success");
                }
                
            }
            else
            {
                MessageBox.Show("A Ocurrido un error");
            }
        }
    }
}
