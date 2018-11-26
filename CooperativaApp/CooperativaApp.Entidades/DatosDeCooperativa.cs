using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Entidades
{
    class DatosDeCooperativa
    {
        public int Id_Dato_Cooperativa { get; set; }
        public decimal Fondo_De_Sepelio { get; set; }
        public decimal Aportacion { get; set; }
        public decimal Sepelio_Titular { get; set; }
        public decimal Sepelio_Familiar { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_De_Registro { get; set; }
    }
}
