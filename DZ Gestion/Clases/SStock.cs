using System;

namespace Prueba_Rene.Clases
{
    class SStock
    {
        private int id_prod;
        private DateTime ult_fecha_modif;
        private double cantidad_actual;

        public int Id_prod { get => id_prod; set => id_prod = value; }
        public DateTime Ult_fecha_modif { get => ult_fecha_modif; set => ult_fecha_modif = value; }
        public double Cantidad_actual { get => cantidad_actual; set => cantidad_actual = value; }
    }
}
