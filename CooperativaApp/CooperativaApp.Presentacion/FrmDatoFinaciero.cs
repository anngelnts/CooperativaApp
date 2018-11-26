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
    public partial class FrmDatoFinaciero : Form
    {
        public FrmDatoFinaciero()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
        }
        private void Listar()
        {
            DDatoFinanciero bo = new DDatoFinanciero();

            //DataTable dtb = new DataTable();
            //dtb = NProveedor.Listar();


            //DgvDatosFinancieros.DataSource = bo.Listar();
            DgvDatosFinancieros.ColumnCount = 8;


            foreach (DatoFinanciero item in bo.Listar())
            {
                DgvDatosFinancieros.Rows.Add(
                   item.Id_Dato_Financiero.ToString(),
                   item.TEA.ToString(),
                   (item.TEM*100).ToString("N3"),
                   (item.TED*100).ToString("N3"),
                   (item.ITF).ToString("N3"),
                   item.Seguro_Desgravamen.ToString("N3"),
                   item.Otros.ToString("N3"),
                   item.Estado.ToString(),
                   item.FechaRegistro.ToString("dd-MM-yyyy")

                   );
            }


        }

        private void FrmDatoFinaciero_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoDatoFinanciero frm = new FrmNuevoDatoFinanciero();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }
    }
}
