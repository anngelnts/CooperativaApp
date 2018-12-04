using CooperativaApp.Datos;
using CooperativaApp.Entidades;
using CooperativaApp.Comun;
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
    public partial class FrmSimuladorDePrestamo : Form
    {
        public FrmSimuladorDePrestamo()
        {
            InitializeComponent();
        }

        public void Dato_Financiero()
        {
            DDatoFinanciero boDatoFinanciero = new DDatoFinanciero();
            DatoFinanciero beDatoFinanciero = new DatoFinanciero();
            beDatoFinanciero = boDatoFinanciero.Dato_Financiero_Activo();

 
            TxtTEA.Text = beDatoFinanciero.TEA.ToString("N3");
            txtTEM.Text = (beDatoFinanciero.TEM * 100).ToString("N3");
            txtTED.Text = (beDatoFinanciero.TED * 100).ToString("N3");
            txtITF.Text = (beDatoFinanciero.ITF).ToString("N3");
            txtSegDesgravamen.Text = (beDatoFinanciero.Seguro_Desgravamen).ToString("N3");
            txtSegMultiriesgo.Text = (beDatoFinanciero.Seguro_Multiriesgo).ToString("N3");
            txtOtros.Text = (beDatoFinanciero.Otros).ToString("N3");
        }

        private void FrmSimuladorDePrestamo_Load(object sender, EventArgs e)
        {
            Dato_Financiero();
            CbxNumeroCuotas.SelectedIndex = 1;

        }

        private void BtnSimular_Click(object sender, EventArgs e)
        {
            //// DATO FINANCIERO ACTIVO
            DDatoFinanciero boDatoFinanciero = new DDatoFinanciero();
            DatoFinanciero beDatoFinanciero = new DatoFinanciero();
            beDatoFinanciero = boDatoFinanciero.Dato_Financiero_Activo();

            double TEA = Convert.ToDouble(beDatoFinanciero.TEA);
            double TEM = Convert.ToDouble(beDatoFinanciero.TEM);
            double TED = Convert.ToDouble(beDatoFinanciero.TED);
            double Tasa_Seg_Desgravamen = Convert.ToDouble(beDatoFinanciero.Seguro_Desgravamen);
            double Tasa_Seg_Multiriesgo = Convert.ToDouble(beDatoFinanciero.Seguro_Multiriesgo);
            double Otros = Convert.ToDouble(beDatoFinanciero.Otros);
            double Tasa_ITF = Convert.ToDouble(beDatoFinanciero.ITF);



            ///DATOS DE PRESTAMO
            DateTime Fecha_De_Desembolso = Convert.ToDateTime(txtFecha_Desembolso.Text);
            DateTime Fecha_De_Pago = Convert.ToDateTime(txtFecha_De_Pago.Text);
            double Monto = Convert.ToDouble(TxtMonto.Text);
            int Cuotas = Convert.ToInt32(CbxNumeroCuotas.SelectedItem);
            TimeSpan dgr = Fecha_De_Pago - Fecha_De_Desembolso;

            //////CANTIDAD DE DIAS DE GRACIA          
            int Dias_De_Gracia = dgr.Days;






            dataGridView1.ColumnCount = 12;
            dataGridView1.Rows.Clear();
            ///DATO INICIAL
            dataGridView1.Rows.Add(
                    "0",
                    Fecha_De_Pago.ToString("dd/MM/yyyy"),
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    Monto.ToString("N3"),
                    "",                  
                    Dias_De_Gracia.ToString(),
                    ""
                    );




            ////INTERES ACUMULADO

            int Dias_Acumulados_IA = 0;
            double Interes_Acumulado = 0;
            for (int i = 1; i <= Cuotas; i++)
            {
                ////DIFERENCIA ENTRE DOS FECHAS
                TimeSpan ts = Fecha_De_Pago.AddMonths(i) - Fecha_De_Pago.AddMonths(i - 1);

                //////CANTIDAD DE DIAS ENTRE FECHAS
                int Dias = ts.Days;

                /////SUMAR DIAS ACUMULADOS
                Dias_Acumulados_IA += Dias;

                ///INTERES ACUMULADO
                Interes_Acumulado += (1 / Math.Pow((1 + TED), Dias_Acumulados_IA));
            }


            

            int Dias_Acumulados = 0;
            double Interes = 0;
            double Interes_Diferido = (Monto * (Math.Pow((1+TED), Dias_De_Gracia) - 1));
            double Saldo_Capital = Monto;
            double Cuota_Base = Monto / Interes_Acumulado;
            double Amortizacion = 0;
            double Cuota_Final = 0;

            double Seguro_Desgravamen = Tasa_Seg_Desgravamen * Monto;
            double Seguro_Multiriesgo = Tasa_Seg_Multiriesgo * Monto;
            double ITF = 0.05;



            for (int i = 1; i <= Cuotas; i++)
            {
               

                ////DIFERENCIA ENTRE DOS FECHAS
                TimeSpan ts = Fecha_De_Pago.AddMonths(i) - Fecha_De_Pago.AddMonths(i - 1);

                //////CANTIDAD DE DIAS ENTRE FECHAS
                int Dias = ts.Days;

                /////SUMAR DIAS ACUMULADOS
                Dias_Acumulados += Dias;

            

                ///INTERES POR CUOTA
                Interes = Saldo_Capital * (Math.Pow((1 + TED), Dias) - 1);


                ///AMORTIZACION 
                Amortizacion = Cuota_Base - Interes;

                ///CUOTA FINAL
                Cuota_Final = Amortizacion + Interes + Interes_Diferido + Seguro_Desgravamen + Seguro_Multiriesgo + ITF;


                ///SALDO CAPITAL
                Saldo_Capital = Saldo_Capital - Amortizacion;

                dataGridView1.Rows.Add(
                    i.ToString(),
                    Fecha_De_Pago.AddMonths(i).ToString("dd/MM/yyyy"),
                    Amortizacion.ToString("N3"),
                    Interes.ToString("N3"),
                    Interes_Diferido.ToString("N3"),
                    Seguro_Desgravamen.ToString("N3"),
                    Seguro_Multiriesgo.ToString("N3"),
                    ITF.ToString("N3"),
                    Saldo_Capital.ToString("N3"),
                    Cuota_Final.ToString("N3"),                  
                    Dias.ToString(),
                    Dias_Acumulados.ToString(),
                    Interes_Acumulado.ToString("N3")
                    );

                Interes_Diferido = 0;
            }

        }

        private void Validar_Decimal(object sender, KeyPressEventArgs e)
        {
            ClsValidaciones.NumerosDecimales(e);
        }
    }
}
