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
    public partial class FrmDatoFinaciero : Form
    {
        public FrmDatoFinaciero()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DatoFinanciero be = new DatoFinanciero
            {
                TEA = Convert.ToDouble(TxtTEA.Text),
                TEM = Convert.ToDouble(TxtTEM.Text),
                TED = Convert.ToDouble(TxtTED.Text),
                SeguroDesgravamen = Convert.ToDouble(TxtSeguroDesgravamen.Text),
                ITF = Convert.ToDouble(TxtITF.Text),
                Otros = Convert.ToDouble(TxtOtros.Text),
                FechaRegistro = DateTime.Now,
                Estado = 1
            };
            DDatoFinanciero bo = new DDatoFinanciero();
            if (bo.Agregar(be))
            {
                Listar();
            }
        }
        private void Listar()
        {
            DDatoFinanciero bo = new DDatoFinanciero();
            DgvData.DataSource = bo.Listar();
        }

        private void FrmDatoFinaciero_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
