using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Entidades
{
    class Egreso
    {
        public int Id_Egreso { get; set; }
        public string Descripcion { get; set; }
        public string Observacion { get; set; }
        public double Monto { get; set; }
        public string Estado { get; set; }
        public int Id_Usuario { get; set; }
        public DateTime Fecha_De_Registro { get; set; }
    }
}
