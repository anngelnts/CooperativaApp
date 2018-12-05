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

namespace CooperativaApp.Presentacion.Acciones
{
    public partial class FrmNuevoDatoCooperativa : Form
    {        
        public FrmNuevoDatoCooperativa()
        {
            InitializeComponent();
            CmbEstado.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (
                Requerido.MostrarMensaje(Requerido.EsDecimal(TxtAportacion.Text),"Aportacion no es valida.") &&
                Requerido.MostrarMensaje(Requerido.EsDecimal(TxtFondoSepelio.Text), "Fondo sepelio no es valida.") &&
                Requerido.MostrarMensaje(Requerido.EsDecimal(TxtSepelioTitular.Text), "Sepelio titular no es valida.") &&
                Requerido.MostrarMensaje(Requerido.EsDecimal(TxtSepelioFamiliar.Text), "Sepelio Familiar no es valida.")
                )
            {
                DDatosDeCooperativa Bo = new DDatosDeCooperativa();
                DatosDeCooperativa Be = new DatosDeCooperativa();
                Be.Estado = CmbEstado.SelectedItem.ToString();
                Be.Aportacion = Convert.ToDecimal(TxtAportacion.Text);
                Be.Fondo_De_Sepelio = Convert.ToDecimal(TxtFondoSepelio.Text);
                Be.Sepelio_Titular = Convert.ToDecimal(TxtSepelioTitular.Text);
                Be.Sepelio_Familiar = Convert.ToDecimal(TxtSepelioFamiliar.Text);
                if (Bo.Agregar(Be))
                {
                    MessageBox.Show("Se agrego correctamente.");
                    FrmDatosCooperativa frm = Owner as FrmDatosCooperativa;
                    frm.Listar();
                    Close();
                }
            }
        }
    }
}
