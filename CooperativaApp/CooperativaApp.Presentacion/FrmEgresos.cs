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

namespace CooperativaApp.Presentacion
{
    public partial class FrmEgresos : Form
    {
        public FrmEgresos()
        {
            InitializeComponent();
        }

        private void FrmEgresos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(Convert.ToInt32(TxtBusqueda.Text));
        }

        public void Listar()
        {
            DEgreso bo = new DEgreso();
            DgvEgresos.Rows.Clear();
            DgvEgresos.ColumnCount = 8;
            foreach (DataRow var in bo.Listar().Rows)
            {
                DgvEgresos.Rows.Add(
                   var[0].ToString(),
                   var[1].ToString(),
                   var[2].ToString(),
                   var[3].ToString(),
                   var[4].ToString(),
                   var[6].ToString(),
                   var[7].ToString(),
                   Convert.ToDateTime(var[5]).ToString("dd/MM/yyyy")
                   );
            }
        }

        private void Buscar(int Identificador)
        {
            DEgreso bo = new DEgreso();
            DgvEgresos.Rows.Clear();
            DgvEgresos.ColumnCount = 8;
            foreach (DataRow var in bo.Buscar(Identificador).Rows)
            {
                DgvEgresos.Rows.Add(
                   var[0].ToString(),
                   var[1].ToString(),
                   var[2].ToString(),
                   var[3].ToString(),
                   var[4].ToString(),
                   var[6].ToString(),
                   var[7].ToString(),
                   Convert.ToDateTime(var[5]).ToString("dd/MM/yyyy")
                   );
            }
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
