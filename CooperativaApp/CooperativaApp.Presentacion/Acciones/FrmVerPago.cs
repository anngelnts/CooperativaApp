using CooperativaApp.Datos;
using CooperativaApp.Entidades;
using CooperativaApp.Comun;
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
    public partial class FrmVerPago : Form
    {
        public FrmVerPago()
        {
            InitializeComponent();
        }

        public static int Id_Pago = 0;


        private void FrmVerPago_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }
        public void Cargar_Datos()
        {
            DPago boPago = new DPago();
            Pago bePago = new Pago();

            DataTable data = boPago.Seleccionar(Id_Pago);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                txtNum_Recibo.Text = row["Num_Boleta"].ToString();
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
                txtSaldo_Capital.Text = row["Saldo_Capital"].ToString();
                txtObservacion.Text = row["Observacion"].ToString();

                txtTipo_Documento.Text = row["Tipo_De_Documento"].ToString();
                txtNum_Documento.Text = row["Num_Documento"].ToString();
                txtNombres.Text = row["Apellidos"].ToString()+ " "+ row["Nombres"].ToString();
                txtTipoDePago.Text = row["Tipo_De_Pago"].ToString();
                txtUsuario.Text = FrmPrincipal.AccesoUsername;


            }
        }
    }
}
