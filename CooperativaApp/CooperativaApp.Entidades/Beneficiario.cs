using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Entidades
{
    public class Beneficiario
    {
        public int Id_Beneficiario { get; set; }
        public int Id_Socio { get; set; }
        public string Tipo_De_Documento { get; set; }
        public string Num_Documento { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Tipo_De_Beneficiario { get; set; }
        public string Parentesco { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_De_Registro { get; set; }
    }
}
