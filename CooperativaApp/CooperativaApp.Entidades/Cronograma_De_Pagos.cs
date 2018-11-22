using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Entidades
{
    class Cronograma_De_Pagos
    {
        public int Id_Cronograma { get; set; }
        public int Id_Prestamo { get; set; }
        public int Num_Cuota { get; set; }
        public DateTime Fecha_De_Vencimiento { get; set; }
        public decimal Amortizacion { get; set; }
        public decimal Interes { get; set; }
        public decimal Interes_Diferido { get; set; }
        public decimal Seg_Desgravamen { get; set; }
        public decimal Seg_Multiriesgo { get; set; }
        public decimal ITF { get; set; }
        public decimal Otros { get; set; }
        public decimal Saldo_Capital { get; set; }
        public decimal Cuota_Fija { get; set; }
        public int Dias { get; set; }
        public int Dias_Acumulados { get; set; }
        public int Dias_Morosidad { get; set; }
        public decimal Monto_Morosidad { get; set; }
        public decimal Cuota_Total { get; set; }
        public DateTime Fecha_De_Pago { get; set; }
        public string Estado { get; set; }
    }
}
