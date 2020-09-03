using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Rene.Clases
{
    class Item_Remito
    {
        private int codigo_rem;
        private int id_prod;
        private double cantidad;
        private double precio_unitario;
        private double subtotal;

        public int Codigo_rem { get => codigo_rem; set => codigo_rem = value; }
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
    }
}
