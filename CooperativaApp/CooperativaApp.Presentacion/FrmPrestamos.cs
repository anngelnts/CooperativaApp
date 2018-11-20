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
            DDatoFinanciero bo = new DDatoFinanciero();
            DgvPrestamo.DataSource = bo.Listar();
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
    }
}
