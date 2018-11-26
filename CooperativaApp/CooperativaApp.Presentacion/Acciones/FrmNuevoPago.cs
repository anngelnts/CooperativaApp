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

        }
    }
}
