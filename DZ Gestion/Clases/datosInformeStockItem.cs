using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Rene.Clases
{
    class datosInformeStockItem
    {
        private int id_prod;
        private int id_rubro;
        private string nombre_rubro;
        private string nombre_prod;
        private string marca_prod;
        private double precio_unitario;
        private double valor_existencia;
        private double total_existencia;

        public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Id_rubro { get => id_rubro; set => id_rubro = value; }
        public string Nombre_rubro { get => nombre_rubro; set => nombre_rubro = value; }
        public string Nombre_prod { get => nombre_prod; set => nombre_prod = value; }
        public string Marca_prod { get => marca_prod; set => marca_prod = value; }
        public double Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        public double Valor_existencia { get => valor_existencia; set => valor_existencia = Math.Round(value, 2); }
        public double Total_existencia { get => total_existencia; set => total_existencia = Math.Round(value, 2); }
    }
}
