using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Entidades
{
    class Aporte
    {
        public int Id_Aporte { get; set; }
        public string Num_Boleta { get; set; }
        public int Id_Socio { get; set; }
        public string Observacion { get; set; }
        public int Id_Dato_Cooperativa { get; set; }
        public decimal Monto_Aporte { get; set; }
        public decimal Monto_Fondo_De_Sepelio { get; set; }
        public decimal Otros { get; set; }
        public decimal Monto_Total { get; set; }
        public string Estado { get; set; }
        public int Id_Usuario { get; set; }
        public DateTime Fecha_De_Registro { get; set; }
    }
}
