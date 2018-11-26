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
            frm.ShowDialog();
        }
        public void Listar()
        {
            DSocio boSobio = new DSocio();
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
    }
}
