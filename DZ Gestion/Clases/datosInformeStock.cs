using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Rene.Clases
{
    class datosInformeStock
    {
        private int id_rubro;
        private string nombre_rubro;
        private double total_valor_existencia;

        public int Id_rubro { get => id_rubro; set => id_rubro = value; }
        public string Nombre_rubro { get => nombre_rubro; set => nombre_rubro = value; }
        public double Total_valor_existencia { get => total_valor_existencia; set => total_valor_existencia = Math.Round(value,2); }
    }
}
