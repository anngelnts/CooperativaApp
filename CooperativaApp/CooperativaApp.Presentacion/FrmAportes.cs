using CooperativaApp.Datos;
using CooperativaApp.Entidades;
using CooperativaApp.Presentacion.Acciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativaApp.Presentacion
{
    public partial class FrmAportes : Form
    {
        public FrmAportes()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            DAportes Bo = new DAportes();
            DgvAportes.DataSource = Bo.Listar();
            try
            {
                DgvAportes.Columns[0].Visible = false;
                DgvAportes.Columns[1].HeaderText = "N° Boleta";
                DgvAportes.Columns[2].HeaderText = "Id Socio";
                DgvAportes.Columns[3].HeaderText = "Observacion";
                DgvAportes.Columns[4].HeaderText = "Id Dato Cooperativa";
                DgvAportes.Columns[5].HeaderText = "Monto Aporte";
                DgvAportes.Columns[6].HeaderText = "Monto Fond. Sepelio";
                DgvAportes.Columns[7].HeaderText = "Otros";
                DgvAportes.Columns[8].HeaderText = "Monto Total";
                DgvAportes.Columns[9].HeaderText = "Otros";
                DgvAportes.Columns[10].HeaderText = "Estado";
                DgvAportes.Columns[11].HeaderText = "Id Usuario";
                DgvAportes.Columns[12].HeaderText = "Fec. Registro";
            }
            catch
            {
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoAporte frm = new FrmNuevoAporte();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void FrmAportes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (DgvAportes.SelectedRows.Count > 0)
            {
                int rowindex = DgvAportes.CurrentRow.Index;
                if (rowindex != -1)
                {
                    Aporte Be = new Aporte();
                    Be.Id_Aporte = Convert.ToInt32(DgvAportes.Rows[rowindex].Cells["Id_Aporte"].Value);
                    Be.Num_Boleta = DgvAportes.Rows[rowindex].Cells["Num_Boleta"].Value.ToString();
                    Be.Id_Socio = Convert.ToInt32(DgvAportes.Rows[rowindex].Cells["Id_Socio"].Value);
                    Be.Observacion = DgvAportes.Rows[rowindex].Cells["Observacion"].Value.ToString();
                    Be.Id_Dato_Cooperativa = Convert.ToInt32(DgvAportes.Rows[rowindex].Cells["Id_Dato_Cooperativa"].Value);
                    Be.Monto_Aporte = Convert.ToDecimal(DgvAportes.Rows[rowindex].Cells["Monto_Aporte"].Value);
                    Be.Monto_Fondo_De_Sepelio = Convert.ToDecimal(DgvAportes.Rows[rowindex].Cells["Monto_Fondo_De_Sepelio"].Value);
                    Be.Otros = Convert.ToDecimal(DgvAportes.Rows[rowindex].Cells["Otros"].Value);
                    Be.Monto_Total = Convert.ToDecimal(DgvAportes.Rows[rowindex].Cells["Monto_Total"].Value);
                    Be.Estado = (DgvAportes.Rows[rowindex].Cells["Estado"].Value).ToString();
                    Be.Id_Usuario = Convert.ToInt32(DgvAportes.Rows[rowindex].Cells["Id_Usuario"].Value);
                    FrmEditarAporte frm = new FrmEditarAporte(Be);
                    AddOwnedForm(frm);
                    frm.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtNumeroDocumentoSocioABuscar.Text != "" )
            {
                try
                {
                    DAportes Bo = new DAportes();
                    DgvAportes.DataSource = Bo.BuscarAportesPorNumeroDocumento(TxtNumeroDocumentoSocioABuscar.Text);
                    DgvAportes.Columns[0].Visible = false;
                    DgvAportes.Columns[1].HeaderText = "N° Boleta";
                    DgvAportes.Columns[2].HeaderText = "Id Socio";
                    DgvAportes.Columns[3].HeaderText = "Observacion";
                    DgvAportes.Columns[4].HeaderText = "Id Dato Cooperativa";
                    DgvAportes.Columns[5].HeaderText = "Monto Aporte";
                    DgvAportes.Columns[6].HeaderText = "Monto Fond. Sepelio";
                    DgvAportes.Columns[7].HeaderText = "Otros";
                    DgvAportes.Columns[8].HeaderText = "Monto Total";
                    DgvAportes.Columns[9].HeaderText = "Otros";
                    DgvAportes.Columns[10].HeaderText = "Estado";
                    DgvAportes.Columns[11].HeaderText = "Id Usuario";
                    DgvAportes.Columns[12].HeaderText = "Fec. Registro";
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Para buscar debe colocar un numero de documento");
            }

            
        }

        private void TxtNumeroDocumentoSocioABuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) ||  e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
