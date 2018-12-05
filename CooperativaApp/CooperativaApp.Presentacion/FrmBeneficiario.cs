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
    public partial class FrmBeneficiario : Form
    {
        public static int IdSocio = 0;
        public static string NumeroDocumentoSocio = "";
        public FrmBeneficiario( int IdSocio , string NumeroDocumentoSocio)
        {
            InitializeComponent();
            FrmBeneficiario.IdSocio = IdSocio;
            FrmBeneficiario.NumeroDocumentoSocio = NumeroDocumentoSocio;
        }

        public void Listar()
        {
            DBeneficiario Bo = new DBeneficiario();
            DgvBeneficiario.DataSource = Bo.Listar(IdSocio);
            try
            {
                DgvBeneficiario.Columns[0].Visible = false;
                DgvBeneficiario.Columns[1].HeaderText = "Id Socio";
                DgvBeneficiario.Columns[2].HeaderText = "Tipo Doc.";
                DgvBeneficiario.Columns[3].HeaderText = "N° Documento";
                DgvBeneficiario.Columns[4].HeaderText = "Apellidos";
                DgvBeneficiario.Columns[5].HeaderText = "Nombres";
                DgvBeneficiario.Columns[6].HeaderText = "Celular";
                DgvBeneficiario.Columns[7].HeaderText = "Telefono";
                DgvBeneficiario.Columns[8].HeaderText = "Tipo de Benef.";
                DgvBeneficiario.Columns[9].HeaderText = "Parentesco";
                DgvBeneficiario.Columns[10].HeaderText = "Estado";
                DgvBeneficiario.Columns[11].HeaderText = "Fec. Registro";
            }
            catch
            {
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoBeneficiaro frm = new FrmNuevoBeneficiaro();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvBeneficiario.SelectedRows.Count > 0)
                {
                    int rowindex = DgvBeneficiario.CurrentRow.Index;
                    if (rowindex != -1)
                    {
                        Beneficiario Be = new Beneficiario();
                        Be.Id_Beneficiario = Convert.ToInt32(DgvBeneficiario.Rows[rowindex].Cells["Id_Beneficiario"].Value);
                        Be.Id_Socio = Convert.ToInt32(DgvBeneficiario.Rows[rowindex].Cells["Id_Socio"].Value);
                        Be.Tipo_De_Documento = DgvBeneficiario.Rows[rowindex].Cells["Tipo_De_Documento"].Value.ToString();
                        Be.Num_Documento = DgvBeneficiario.Rows[rowindex].Cells["Num_Documento"].Value.ToString();
                        Be.Apellidos = DgvBeneficiario.Rows[rowindex].Cells["Apellidos"].Value.ToString();
                        Be.Nombres = DgvBeneficiario.Rows[rowindex].Cells["Nombres"].Value.ToString();
                        Be.Celular = DgvBeneficiario.Rows[rowindex].Cells["Celular"].Value.ToString();
                        Be.Telefono = DgvBeneficiario.Rows[rowindex].Cells["Telefono"].Value.ToString();
                        Be.Tipo_De_Beneficiario = DgvBeneficiario.Rows[rowindex].Cells["Tipo_De_Beneficiario"].Value.ToString();
                        Be.Parentesco = DgvBeneficiario.Rows[rowindex].Cells["Parentesco"].Value.ToString();
                        Be.Estado = (DgvBeneficiario.Rows[rowindex].Cells["Estado"].Value).ToString();
                        FrmEditarBeneficiario frm = new FrmEditarBeneficiario(Be);
                        AddOwnedForm(frm);
                        frm.ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("NO HAY FILAS : -> "+ DgvBeneficiario.Rows.Count);
            }
        }

        private void FrmBeneficiario_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
