using CooperativaApp.Datos;
using CooperativaApp.Presentacion.Acciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativaApp.Presentacion
{
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoPago Frm = new FrmNuevoPago();
            AddOwnedForm(Frm);
            Frm.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            DPago boPago = new DPago();

            DgvPrestamo.Rows.Clear();
            DgvPrestamo.ColumnCount = 9;


            foreach (DataRow var in boPago.Listar().Rows)
            {
                DgvPrestamo.Rows.Add(
                   var["Id_Pago"].ToString(),
                   var["Num_Boleta"].ToString(),
                   var["Id_Prestamo"].ToString(),
                   var["Tipo_De_Documento"].ToString(),
                   var["Num_Documento"].ToString(),
                   var["Num_Cuota"].ToString(),
                   var["Monto_Total"].ToString(),
                   var["Estado"].ToString(),
                   var["Fecha_De_Registro"].ToString()
                   );

            }
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {

        }
    }
}
