using CooperativaApp.Datos;
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
    public partial class FrmCronogramaDePago : Form
    {
        public FrmCronogramaDePago()
        {
            InitializeComponent();
        }
     
        private void FrmCronogramaDePago_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public static int Id_Prestamo = 0;
        public void Listar()
        {
            DCronogramaDePagos boCronograma = new DCronogramaDePagos();

            DgvCronogramaDePago.Rows.Clear();
            DgvCronogramaDePago.ColumnCount = 19;


            foreach (DataRow var in boCronograma.Listar(FrmCronogramaDePago.Id_Prestamo).Rows)
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
                   var["Cuota_Fija"].ToString(),
                   var["Dias"].ToString(),
                   var["Dias_Acumulados"].ToString(),
                   var["Monto_Morosidad"].ToString(),
                   var["Cuota_Total"].ToString(),
                   var["Fecha_De_Pago"].ToString(),
                   var["Estado"].ToString()
                   );

            }

        }
    }
}
