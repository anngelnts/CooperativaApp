using System;

namespace CooperativaApp.Entidades
{
    public class DatoFinanciero
    {
        public int ID { get; set; }
        public double TEA { get; set; }
        public double TEM { get; set; }
        public double TED { get; set; }
        public double SeguroDesgravamen { get; set; }
        public double ITF { get; set; }
        public double Otros { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
    }
}
