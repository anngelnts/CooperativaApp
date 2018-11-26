using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Entidades
{
    public class Prestamo
    {
        public int Id_Prestamo { get; set; }
        public int Id_Socio { get; set; }
        public int Id_Dato_Financiero { get; set; }
        public decimal Monto { get; set; }
        public int Num_De_Cuotas { get; set; }
        public string Observaciones { get; set; }
        public string Anexos { get; set; }      
        public DateTime Fecha_De_Desembolso { get; set; }
        public int Dias_De_Gracia { get; set; }
        public DateTime Fecha_De_Pago { get; set; }
        public decimal Cuota_Base { get; set; }
        public decimal Interes { get; set; }
        public decimal Interes_Diferido { get; set; }
        public decimal Cuota_Fija { get; set; }
        public decimal Saldo_Capital { get; set; }
        public int Usuario_Sol { get; set; }
        public int Usuario_Val { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_De_Registro { get; set; }

    }
}
