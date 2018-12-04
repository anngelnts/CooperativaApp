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
    public partial class FrmEditarPrestamo : Form
    {
        public FrmEditarPrestamo()
        {
            InitializeComponent();
        }

        public static int Id_Prestamo =0;
        private void FrmEditarPrestamo_Load(object sender, EventArgs e)
        {
            

            Datos_De_Prestamo(FrmEditarPrestamo.Id_Prestamo);
        }

        public void Datos_De_Prestamo(int Id_Prestamo)
        {
            DPrestamo boPrestamo = new DPrestamo();
            DataTable data = boPrestamo.Seleccionar(Id_Prestamo);
           
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                ////DATOS FINANCIEROS
                TxtTEA.Text = (Convert.ToDouble(row["TEA"])).ToString("N3");
                txtTEM.Text = ((double)row["TEM"] * 100).ToString("N3");
                txtTED.Text = ((double)row["TED"] * 100).ToString("N3");
                txtITF.Text = ((double)row["ITF"] * 100).ToString("N3");
                txtSegDesgravamen.Text = ((double)row["Seguro_Desgravamen"] * 100).ToString("N3");
                txtSegMultiriesgo.Text = ((double)row["Seguro_Multiriesgo"] * 100).ToString("N3");
                txtOtros.Text = ((double)row["Otros"]).ToString("N3");


                /////DATOS DE SOCIO
                txtTipo_De_Documento.Text = row["Tipo_De_Documento"].ToString();
                txtNum_Documento.Text = row["Num_Documento"].ToString();
                txtNombres.Text = row["Nombres"].ToString();
                txtApellidos.Text = row["Apellidos"].ToString();


                ///DATOS DE PRESTAMO               
                txtMonto.Text = row["Monto"].ToString();
                cbxNum_De_Cuotas.SelectedItem = row["Num_De_Cuotas"].ToString();
                txtEstado.Text = row["Estado"].ToString();
                txtFecha_De_Registro.Text = row["Fecha_De_Registro"].ToString();
                txtFecha_Desembolso.Text = row["Fecha_De_Desembolso"].ToString();
                txtFecha_De_Pago.Text = row["Fecha_De_Pago"].ToString();
                txtCuota_Base.Text = row["Cuota_Base"].ToString();
                txtInteres.Text = row["Interes"].ToString();
                txtCuota_Fija.Text = row["Cuota_Fija"].ToString();
                txtSaldo_Capital.Text = row["Saldo_Capital"].ToString();

                if (true)
                {

                }
            }
            else
            {
               
            }
     


            
        }

        private void BtnGenerarPrestamo_Click(object sender, EventArgs e)
        {

            DPrestamo boPrestamo = new DPrestamo();
            DataTable data = boPrestamo.Seleccionar(FrmEditarPrestamo.Id_Prestamo);
            DataRow row = data.Rows[0];

            //// DATO FINANCIERO ACTIVO
            DDatoFinanciero boDatoFinanciero = new DDatoFinanciero();
            DatoFinanciero beDatoFinanciero = new DatoFinanciero();

           
            beDatoFinanciero = boDatoFinanciero.Seleccionar(Convert.ToInt32(row["Id_Dato_Financiero"]));

            double TEA = Convert.ToDouble(beDatoFinanciero.TEA);
            double TEM = Convert.ToDouble(beDatoFinanciero.TEM);
            double TED = Convert.ToDouble(beDatoFinanciero.TED);
            double Tasa_Seg_Desgravamen = Convert.ToDouble(beDatoFinanciero.Seguro_Desgravamen);
            double Tasa_Seg_Multiriesgo = Convert.ToDouble(beDatoFinanciero.Seguro_Multiriesgo);
            double Otros = Convert.ToDouble(beDatoFinanciero.Otros);
            double Tasa_ITF = Convert.ToDouble(beDatoFinanciero.ITF);

    

            ///DATOS DE PRESTAMO
            DateTime Fecha_De_Desembolso = Convert.ToDateTime(txtFecha_Desembolso.Value);
            DateTime Fecha_De_Pago = Convert.ToDateTime(txtFecha_De_Pago.Value);
            double Monto = Convert.ToDouble(txtMonto.Text);
            int Cuotas = Convert.ToInt32(cbxNum_De_Cuotas.SelectedItem);
            TimeSpan dgr = Fecha_De_Pago - Fecha_De_Desembolso;

            //////CANTIDAD DE DIAS DE GRACIA          
            int Dias_De_Gracia = dgr.Days;


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
            double Interes_Total = Monto * (Math.Pow((1 + TED), Dias_Acumulados_IA) - 1);
            double Interes_Diferido = (Monto * (Math.Pow((1 + TED), Dias_De_Gracia) - 1));
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


                Interes_Diferido = 0;
            }


            ////RESULTADO DE PRESTAMO
            txtCuota_Base.Text = Cuota_Base.ToString("N2");
            txtCuota_Fija.Text = Cuota_Final.ToString("N2");
            txtInteres.Text = Interes_Total.ToString("N2");
            txtSaldo_Capital.Text = Monto.ToString("N2");
            txtInteres_Diferido.Text = Interes_Diferido.ToString("N2");
            txtDias_De_Gracia.Text = Dias_De_Gracia.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Prestamo bePrestamo = new Prestamo();
            DPrestamo boPrestamo = new DPrestamo();

            bePrestamo.Id_Prestamo = FrmEditarPrestamo.Id_Prestamo;
            bePrestamo.Monto = Convert.ToDecimal(txtMonto.Text);
            bePrestamo.Num_De_Cuotas = Convert.ToInt32(cbxNum_De_Cuotas.SelectedItem);
            bePrestamo.Fecha_De_Desembolso = Convert.ToDateTime(txtFecha_Desembolso.Value);
            bePrestamo.Fecha_De_Pago = Convert.ToDateTime(txtFecha_De_Pago.Value);
            bePrestamo.Cuota_Base = Convert.ToDecimal(txtCuota_Base.Text);
            bePrestamo.Cuota_Fija = Convert.ToDecimal(txtCuota_Fija.Text);
            bePrestamo.Interes = Convert.ToDecimal(txtInteres.Text);
            bePrestamo.Interes_Diferido = Convert.ToDecimal(txtInteres_Diferido.Text);
            bePrestamo.Dias_De_Gracia = Convert.ToInt32(txtDias_De_Gracia.Text);
            bePrestamo.Saldo_Capital = Convert.ToDecimal(txtSaldo_Capital.Text);
            bePrestamo.Usuario_Val = FrmPrincipal.AccesoUsernameID;
            bePrestamo.Estado = "APROBADO";
            bePrestamo.Anexos = "";
            if (boPrestamo.Actualizar(bePrestamo))
            {

                /////GUARDAR CRONOGRAMA DE PAGOS

                DataTable data = boPrestamo.Seleccionar(FrmEditarPrestamo.Id_Prestamo);
                DataRow row = data.Rows[0];

                //// DATO FINANCIERO ACTIVO
                DDatoFinanciero boDatoFinanciero = new DDatoFinanciero();
                DatoFinanciero beDatoFinanciero = new DatoFinanciero();


                beDatoFinanciero = boDatoFinanciero.Seleccionar(Convert.ToInt32(row["Id_Dato_Financiero"]));

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
                double Monto = Convert.ToDouble(txtMonto.Text);
                int Cuotas = Convert.ToInt32(cbxNum_De_Cuotas.SelectedItem);
                TimeSpan dgr = Fecha_De_Pago - Fecha_De_Desembolso;

                //////CANTIDAD DE DIAS DE GRACIA          
                int Dias_De_Gracia = dgr.Days;


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
                double Interes_Total = Monto * (Math.Pow((1 + TED), Dias_Acumulados_IA) - 1);
                double Interes_Diferido = (Monto * (Math.Pow((1 + TED), Dias_De_Gracia) - 1));
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


                    CronogramaDePagos beCronogramaDePagos = new CronogramaDePagos();
                    DCronogramaDePagos boCronogramaDePagos = new DCronogramaDePagos();

                    beCronogramaDePagos.Id_Prestamo = FrmEditarPrestamo.Id_Prestamo;
                    beCronogramaDePagos.Num_Cuota = i;
                    beCronogramaDePagos.Fecha_De_Vencimiento = Fecha_De_Pago.AddMonths(i);
                    beCronogramaDePagos.Amortizacion = Convert.ToDecimal(Amortizacion);
                    beCronogramaDePagos.Interes = Convert.ToDecimal(Interes);
                    beCronogramaDePagos.Interes_Diferido = Convert.ToDecimal(Interes_Diferido);
                    beCronogramaDePagos.Seg_Desgravamen = Convert.ToDecimal(Seguro_Desgravamen);
                    beCronogramaDePagos.Seg_Multiriesgo = Convert.ToDecimal(Seguro_Multiriesgo);
                    beCronogramaDePagos.ITF = Convert.ToDecimal(ITF);
                    beCronogramaDePagos.Otros = Convert.ToDecimal(Otros);
                    beCronogramaDePagos.Saldo_Capital = Convert.ToDecimal(Saldo_Capital);
                    beCronogramaDePagos.Cuota_Fija = Convert.ToDecimal(Cuota_Final);
                    beCronogramaDePagos.Dias = Dias;
                    beCronogramaDePagos.Dias_Acumulados = Dias_Acumulados;
                    beCronogramaDePagos.Dias_Morosidad = 0;
                    beCronogramaDePagos.Monto_Morosidad = 0;
                    beCronogramaDePagos.Cuota_Total = 0;
                    beCronogramaDePagos.Estado = "PENDIENTE";

                    if (boCronogramaDePagos.Agregar(beCronogramaDePagos))
                    {
                        //MessageBox.Show("Actualizado");
                    }
                    else
                    {
                        //MessageBox.Show("error");
                    }
                    Interes_Diferido = 0;
                }


                FrmPrincipal.Main.ChangeMessage("Se ha Modificado Exitasamente el prestamo.", "Success");
                FrmPrestamos frmSocio = Owner as FrmPrestamos;
                frmSocio.Listar();
                this.Close();

            }
            else
            {
                MessageBox.Show("A Ocurrido un error");
            }





        }

       
    }
}
