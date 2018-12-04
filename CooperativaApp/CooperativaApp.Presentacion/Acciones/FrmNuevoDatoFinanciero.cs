using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CooperativaApp.Datos;
using CooperativaApp.Entidades;
using CooperativaApp.Comun;

namespace CooperativaApp.Presentacion.Acciones
{
    public partial class FrmNuevoDatoFinanciero : Form
    {
        public FrmNuevoDatoFinanciero()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            double cTEA = Convert.ToDouble(TxtTEA.Text);
            double cTEM = (Math.Pow((1 + (cTEA/100)),(1/(double)12)) -1);
            double cTED = (Math.Pow((1 + (cTEM)), (1 /(double)30)) - 1);

            

            DatoFinanciero be = new DatoFinanciero
            {
                TEA = Convert.ToDouble(cTEA),
                TEM = Convert.ToDouble(cTEM),
                TED = Convert.ToDouble(cTED),
                Seguro_Desgravamen = Convert.ToDouble(txtSegDesgravamen.Text),
                ITF = Convert.ToDouble(txtITF.Text),
                Otros = Convert.ToDouble(txtOtros.Text),
                Seguro_Multiriesgo = Convert.ToDouble(txtSegMultiriesgo.Text),
                FechaRegistro = DateTime.Now,
                Estado = "ACTIVO"
            };
            DDatoFinanciero bo = new DDatoFinanciero();
            bo.Anular_All();
            if (bo.Agregar(be))
            {
                FrmPrincipal.Main.ChangeMessage("Se ha Registrado Exitasamente el dato financiero.", "Success");
                FrmDatoFinaciero frmSocio = Owner as FrmDatoFinaciero;
                frmSocio.Listar();
                this.Close();
            }
            else
            {
                MessageBox.Show("A Ocurrido un error");
            }
        }

        private void Validar_Decimal(object sender, KeyPressEventArgs e)
        {
            ClsValidaciones.NumerosDecimales(e);
        }
    }
}
