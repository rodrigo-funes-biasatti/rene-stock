using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Rene.Clases
{
    class Condicion_Venta
    {
        private int id_condicion_venta;
        private string descripcion;

        public int Id_condicion_venta { get => id_condicion_venta; set => id_condicion_venta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
