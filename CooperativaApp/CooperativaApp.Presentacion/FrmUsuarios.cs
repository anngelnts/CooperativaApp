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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            DUsuario bo = new DUsuario();
            DgvUsuarios.Rows.Clear();
            DgvUsuarios.ColumnCount = 10;
            foreach (Usuario item in bo.Listar())
            {
                DgvUsuarios.Rows.Add(
                   item.Id_Usuario.ToString(),
                   item.Id_Tipo_De_Usuario.ToString(),
                   item.TipoUsuario.ToString(),
                   item.Username.ToString(),
                   item.Password.ToString(),
                   item.Nombre.ToString(),
                   item.Apellido.ToString(),
                   item.Celular.ToString(),
                   item.Estado.ToString(),
                   Convert.ToDateTime(item.Fecha_Registro).ToString("dd/MM/yyyy")
                );
            }
            RowStyle();
        }

        private void RowStyle()
        {
            try
            {
                foreach (DataGridViewRow row in DgvUsuarios.Rows)
                {
                    if (row.Cells[8].Value.ToString() == "Inactivo")
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

        private void Buscar(string Username)
        {
            DUsuario bo = new DUsuario();
            DgvUsuarios.Rows.Clear();
            DgvUsuarios.ColumnCount = 10;
            foreach (Usuario item in bo.Buscar(Username))
            {
                DgvUsuarios.Rows.Add(
                   item.Id_Usuario.ToString(),
                   item.Id_Tipo_De_Usuario.ToString(),
                   item.TipoUsuario.ToString(),
                   item.Username.ToString(),
                   item.Password.ToString(),
                   item.Nombre.ToString(),
                   item.Apellido.ToString(),
                   item.Celular.ToString(),
                   item.Estado.ToString(),
                   Convert.ToDateTime(item.Fecha_Registro).ToString("dd/MM/yyyy")
                );
            }
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
            FrmUsuarioCU frm = new FrmUsuarioCU();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count > 0)
            {
                int rowindex = DgvUsuarios.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        FrmUsuarioCU frm = new FrmUsuarioCU();
                        FrmUsuarioCU.modificar = 1;
                        FrmUsuarioCU.Identificador = Convert.ToInt32(DgvUsuarios.CurrentRow.Cells[0].Value);

                        FrmUsuarioCU.BtnGE = true;

                        FrmUsuarioCU.cbxtipousuarioselected = Convert.ToInt32(DgvUsuarios.CurrentRow.Cells[1].Value);

                        AddOwnedForm(frm);
                        frm.Text = "Modificar Usuario";

                        frm.TxtUsuario.Text = DgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                        frm.TxtNombre.Text = DgvUsuarios.CurrentRow.Cells[5].Value.ToString();
                        frm.TxtApellido.Text = DgvUsuarios.CurrentRow.Cells[6].Value.ToString();
                        frm.TxtCelular.Text = DgvUsuarios.CurrentRow.Cells[7].Value.ToString();

                        frm.TxtUsuario.Enabled = false;

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

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count > 0)
            {
                int rowindex = DgvUsuarios.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        if (MessageBox.Show("¿Esta seguro de cambiar estado?", "Cooperativa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(DgvUsuarios.CurrentRow.Cells[0].Value);
                            string estado = DgvUsuarios.CurrentRow.Cells[8].Value.ToString();
                            estado = estado.Equals("Activo") ? "Inactivo" : "Activo";
                            DUsuario bo = new DUsuario();
                            if (bo.CambiarEstado(id, estado))
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

        private void BtnTipoUsuario_Click(object sender, EventArgs e)
        {
            FrmTipoUsuario frm = new FrmTipoUsuario();
            frm.ShowDialog();
        }
    }
}
