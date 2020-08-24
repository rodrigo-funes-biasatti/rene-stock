using Prueba_Rene.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Rene.Clases
{
    class Rubro
    {
        private int id_rubro;
        private string nombre;
        private string descripcion;

        public int Id_rubro { get => id_rubro; set => id_rubro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
