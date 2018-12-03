using CooperativaApp.Datos;
using CooperativaApp.Entidades;
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
    public partial class FrmDatosCooperativa : Form
    {
        public FrmDatosCooperativa()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            DDatosDeCooperativa Bo = new DDatosDeCooperativa();
            DgvDatosCooperativa.DataSource = Bo.Listar();
            DgvDatosCooperativa.Columns[0].Visible = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoDatoCooperativa frm = new FrmNuevoDatoCooperativa();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvDatosCooperativa.SelectedRows.Count > 0)
            {
                int rowindex = DgvDatosCooperativa.CurrentRow.Index;
                if (rowindex != -1)
                {
                    DatosDeCooperativa Be = new DatosDeCooperativa();
                    Be.Id_Dato_Cooperativa = Convert.ToInt32(DgvDatosCooperativa.Rows[rowindex].Cells["Id_Dato_Cooperativa"].Value);
                    Be.Fondo_De_Sepelio = Convert.ToDecimal(DgvDatosCooperativa.Rows[rowindex].Cells["Fondo_De_Sepelio"].Value);
                    Be.Aportacion = Convert.ToDecimal(DgvDatosCooperativa.Rows[rowindex].Cells["Aportacion"].Value);
                    Be.Sepelio_Titular = Convert.ToDecimal(DgvDatosCooperativa.Rows[rowindex].Cells["Sepelio_Titular"].Value);
                    Be.Sepelio_Familiar = Convert.ToDecimal(DgvDatosCooperativa.Rows[rowindex].Cells["Sepelio_Familiar"].Value);
                    Be.Estado = (DgvDatosCooperativa.Rows[rowindex].Cells["Estado"].Value).ToString();
                    Be.Fecha_De_Registro = Convert.ToDateTime(DgvDatosCooperativa.Rows[rowindex].Cells["Fecha_De_Registro"].Value);
                    FrmEditarDatosCooperativa frm = new FrmEditarDatosCooperativa(Be);
                    AddOwnedForm(frm);
                    frm.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }

        }

        private void FrmDatosCooperativa_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
