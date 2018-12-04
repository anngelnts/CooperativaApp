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
    public partial class FrmSocio : Form
    {
        public FrmSocio()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoSocio frm = new FrmNuevoSocio();
            AddOwnedForm(frm);
            frm.Text = "NUEVO SOCIO";
            frm.ShowDialog();
        }
        public void Listar()
        {
            DSocio boSobio = new DSocio();
            DgvSocios.Rows.Clear();
            DgvSocios.ColumnCount = 9;

            foreach (Socio item in boSobio.Listar())
            {
                DgvSocios.Rows.Add(
                   item.Id_Socio.ToString(),
                   item.Tipo_De_Documento.ToString(),
                   item.Num_Documento.ToString(),
                   item.Apellidos.ToString(),
                   item.Nombres.ToString(),
                   item.Celular.ToString(),
                   item.Email.ToString(),
                   item.Estado.ToString(),
                   item.Fecha_De_Registro.ToString("dd-MM-yyyy")

                   );
            }

        }

        private void FrmSocio_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string Num_Documento = TxtBusqueda.Text;

            DSocio boSobio = new DSocio();
            DgvSocios.Rows.Clear();
            DgvSocios.ColumnCount = 9;

            foreach (Socio item in boSobio.Buscar_Socio(Num_Documento))
            {
                DgvSocios.Rows.Add(
                   item.Id_Socio.ToString(),
                   item.Tipo_De_Documento.ToString(),
                   item.Num_Documento.ToString(),
                   item.Apellidos.ToString(),
                   item.Nombres.ToString(),
                   item.Celular.ToString(),
                   item.Email.ToString(),
                   item.Estado.ToString(),
                   item.Fecha_De_Registro.ToString("dd-MM-yyyy")

                   );
            }
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvSocios.SelectedRows.Count > 0)
            {
                int rowindex = DgvSocios.CurrentRow.Index;
                if (rowindex != -1)
                {
                    FrmNuevoSocio.F_Id_Socio = Convert.ToInt32(DgvSocios.CurrentRow.Cells[0].Value);
                    FrmNuevoSocio frm = new FrmNuevoSocio();
                    frm.Text = "MODIFICAR SOCIO";
                    AddOwnedForm(frm);
                    frm.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void BtnVerBeneficiarios_Click(object sender, EventArgs e)
        {
            if (DgvSocios.SelectedRows.Count > 0)
            {
                int rowindex = DgvSocios.CurrentRow.Index;
                if (rowindex != -1)
                {
                    int Id_Socio = Convert.ToInt32(DgvSocios.CurrentRow.Cells[0].Value);
                    string NumeroDocumentoSocio = (DgvSocios.CurrentRow.Cells[2].Value).ToString();
                    FrmBeneficiario frm = new FrmBeneficiario(Id_Socio,NumeroDocumentoSocio);
                    frm.Text = "VER BENEFICIARIOS DE UN SOCIO";
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
