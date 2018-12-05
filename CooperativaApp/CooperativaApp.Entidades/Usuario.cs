using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Entidades
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public int Id_Tipo_De_Usuario { get; set; }
        public string TipoUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
