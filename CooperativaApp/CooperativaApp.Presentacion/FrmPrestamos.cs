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
    public partial class FrmPrestamos : Form
    {
        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            DPrestamo boPrestamo = new DPrestamo();
            
            DgvPrestamo.Rows.Clear();
            DgvPrestamo.ColumnCount = 8;


            foreach (DataRow var in boPrestamo.Listar().Rows)
            {
                DgvPrestamo.Rows.Add(
                   var[0].ToString(),
                   var[6].ToString(),
                   var[7].ToString(),
                   var[8].ToString() +" " +var[9].ToString(),
                   var[2].ToString(),
                   var[3].ToString(),
                   var[4].ToString(),
                   var[5].ToString()
                   );

            }
        }

        private void Buscar(string KeyWoard)
        {
            DDatoFinanciero bo = new DDatoFinanciero();
            DgvPrestamo.DataSource = bo.Buscar(KeyWoard);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TxtBusqueda.Text);
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoPrestamo frm = new FrmNuevoPrestamo();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
           

            if (DgvPrestamo.SelectedRows.Count > 0)
            {
                int rowindex = DgvPrestamo.CurrentRow.Index;
                if (rowindex != -1)
                {
                    FrmEditarPrestamo.Id_Prestamo = Convert.ToInt32(DgvPrestamo.CurrentRow.Cells[0].Value);
                    FrmEditarPrestamo frm = new FrmEditarPrestamo();
                    AddOwnedForm(frm);
                    frm.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }
    }
}
