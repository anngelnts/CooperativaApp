using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Entidades
{
    public class TipoUsuario
    {
        public int Id_Tipo_De_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_registro { get; set; }
    }
}
