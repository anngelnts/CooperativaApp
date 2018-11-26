using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Entidades
{
    public class Socio
    {
        public int Id_Socio { get; set; }
        public string Tipo_De_Documento { get; set; }
        public string Num_Documento { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public DateTime Fecha_De_Nacimiento { get; set; }
        public string Sexo { get; set; }
        public string Estado_Civil { get; set; }
        public string Profesion { get; set; }
        public string Nivel_De_Instruccion { get; set; }
        public string Direccion { get; set; }
        public string Distrito { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }
        public string Referencia { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Envio_De_Cronogramas_De_Pago { get; set; }
        public string Nombre_De_Empresa { get; set; }
        public DateTime Fecha_De_Ingreso { get; set; }
        public decimal Ingreso_Mensual_Neto { get; set; }
        public string Cargo { get; set; }
        public string Area_De_Trabajo { get; set; }
        public string Direccion_De_Empresa { get; set; }
        public string Distrito_De_Empresa { get; set; }
        public string Provincia_De_Empresa { get; set; }
        public string Departamento_De_Empresa { get; set; }
        public string Referencia_De_Empresa { get; set; }
        public string Telefono_De_Empresa { get; set; }
        public string Modalidad_De_Contratacion { get; set; }
        public string Centro_De_Trabajo { get; set; }
        public string Nivel { get; set; }
        public decimal Monto_Acumulado { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_De_Registro { get; set; }
    }
}
