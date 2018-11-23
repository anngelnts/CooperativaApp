using System;

namespace CooperativaApp.Entidades
{
    public class DatoFinanciero
    {
        public int Id_Dato_Financiero { get; set; }
        public double TEA { get; set; }
        public double TEM { get; set; }
        public double TED { get; set; }
        public double Seguro_Desgravamen { get; set; }
        public double ITF { get; set; }
        public double Otros { get; set; }
        public double Seguro_Multiriesgo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estado { get; set; }
    }
}
