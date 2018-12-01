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
            RowStyle();
        }

        private void RowStyle()
        {
            try
            {
                foreach (DataGridViewRow row in DgvEgresos.Rows)
                {
                    if (row.Cells[4].Value.ToString() == "Inactivo")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(239, 83, 80);
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Algo salio mal");
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
            FrmEgresoCU frm = new FrmEgresoCU();
            AddOwnedForm(frm);
            frm.Text = "Nuevo Egreso";
            frm.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvEgresos.SelectedRows.Count > 0)
            {
                int rowindex = DgvEgresos.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        FrmEgresoCU frm = new FrmEgresoCU();
                        FrmEgresoCU.modificar = 1;
                        FrmEgresoCU.Identificador = Convert.ToInt32(DgvEgresos.CurrentRow.Cells[0].Value);
                        AddOwnedForm(frm);
                        frm.Text = "Modificar Egreso";
                        frm.TxtDescripcion.Text = DgvEgresos.CurrentRow.Cells[1].Value.ToString();
                        frm.TxtObservacion.Text = DgvEgresos.CurrentRow.Cells[2].Value.ToString();
                        frm.TxtMonto.Text = Convert.ToDouble(DgvEgresos.CurrentRow.Cells[3].Value).ToString("N2");
                        frm.TxtDescripcion.ReadOnly = true;
                        frm.TxtMonto.ReadOnly = true;
                        frm.ShowDialog();
                    }
                    catch
                    {
                        Console.WriteLine("Error al Seleccionar una fila");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void TxtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != Convert.ToChar(Keys.Enter)))
            {
                //Solo se permiten numeros
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            if (DgvEgresos.SelectedRows.Count > 0)
            {
                int rowindex = DgvEgresos.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        if (MessageBox.Show("¿Esta seguro de cambiar estado?", "Cooperativa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(DgvEgresos.CurrentRow.Cells[0].Value);
                            string estado = DgvEgresos.CurrentRow.Cells[4].Value.ToString();
                            estado = estado.Equals("Activo") ? "Inactivo" : "Activo";
                            DEgreso bo = new DEgreso();
                            if(bo.CambiarEstado(id,estado))
                            {
                                Listar();
                                FrmPrincipal.Main.ChangeMessage("Se cambio de estado correctamente", "Success");
                            }
                            else
                            {
                                FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error al Seleccionar una fila");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }
    }
}
