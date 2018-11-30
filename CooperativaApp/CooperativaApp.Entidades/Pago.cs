using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Entidades
{
    public class Pago
    {
        public int Id_Pago { get; set; }
        public string Num_Boleta { get; set; }
        public int Id_Cronograma { get; set; }
        public string Observacion { get; set; }
        public string Tipo_De_Pago { get; set; }
        public decimal Cuota_Fija { get; set; }
        public decimal Dias_Morosidad { get; set; }
        public decimal Monto_Morosidad { get; set; }
        public decimal Monto_Total { get; set; }
        public string Estado { get; set; }
        public int Id_Usuario { get; set; }
        public DateTime Fecha_De_Registro { get; set; }
    }
}
