using CooperativaApp.Datos;
using CooperativaApp.Entidades;
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
    public partial class FrmTipoUsuario : Form
    {
        public FrmTipoUsuario()
        {
            InitializeComponent();
        }

        public static int modificar = 0;

        private static int Identificador;
        private static string Estado;

        private void FrmTipoUsuario_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            DTipoUsuario bo = new DTipoUsuario();
            DgvTipoUsuario.Rows.Clear();
            DgvTipoUsuario.ColumnCount = 4;
            foreach (TipoUsuario item in bo.Listar())
            {
                DgvTipoUsuario.Rows.Add(
                   item.Id_Tipo_De_Usuario.ToString(),
                   item.Nombre.ToString(),
                   item.Estado.ToString(),
                   Convert.ToDateTime(item.Fecha_registro).ToString("dd/MM/yyyy")
                );
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingrese nombre", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombre.Focus();
            }
            else
            {
                Guardar();
            }
        }

        private void Guardar()
        {
            TipoUsuario be = new TipoUsuario
            {
                Id_Tipo_De_Usuario = Identificador,
                Nombre = TxtNombre.Text,
                Estado = Estado
            };
            DTipoUsuario bo = new DTipoUsuario();
            if (modificar == 0)
            {
                Estado = "Activo";
                if (bo.Agregar(be))
                {
                    TxtNombre.Text = "";
                    Listar();
                    FrmPrincipal.Main.ChangeMessage("Tipo de Usuario agregado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
            else if (modificar == 1)
            {
                if (bo.Modificar(be))
                {
                    Listar();
                    FrmPrincipal.Main.ChangeMessage("Tipo de Usuario modificado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvTipoUsuario.SelectedRows.Count > 0)
            {
                int rowindex = DgvTipoUsuario.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        modificar = 1;
                        BtnAgregar.Text = "Guardar";
                        BtnAgregar.BackColor = Color.FromArgb(0, 166, 81);
                        BtnCancelar.Visible = true;
                        BtnEditar.Enabled = false;
                        Identificador = Convert.ToInt32(DgvTipoUsuario.CurrentRow.Cells[0].Value);
                        TxtNombre.Text = DgvTipoUsuario.CurrentRow.Cells[1].Value.ToString();
                        Estado = DgvTipoUsuario.CurrentRow.Cells[2].Value.ToString();
                    }
                    catch
                    {
                        //
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            modificar = 0;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.BackColor = Color.FromArgb(1, 87, 155);
            TxtNombre.Text = "";
            BtnCancelar.Visible = false;
            BtnEditar.Enabled = true;
        }

        private void DgvTipoUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modificar == 1)
            {
                try
                {
                    Identificador = Convert.ToInt32(DgvTipoUsuario.CurrentRow.Cells[0].Value);
                    TxtNombre.Text = DgvTipoUsuario.CurrentRow.Cells[1].Value.ToString();
                    Estado = DgvTipoUsuario.CurrentRow.Cells[2].Value.ToString();
                }
                catch
                {
                    //
                }
            }
        }
    }
}
