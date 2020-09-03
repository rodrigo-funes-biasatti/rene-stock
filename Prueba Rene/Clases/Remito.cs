using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Rene.Clases
{
    class Remito
    {
        private int codigo_remito;
        private int id_condicion_venta;
        private int factura_nro;
        private DateTime fecha_remito;
        private int codigo_barra;
        private string observaciones;
        private double total_remito;
        private string vendedor;

        public int Codigo_remito { get => codigo_remito; set => codigo_remito = value; }
        public int Id_condicion_venta { get => id_condicion_venta; set => id_condicion_venta = value; }
        public int Factura_nro { get => factura_nro; set => factura_nro = value; }
        public DateTime Fecha_remito { get => fecha_remito; set => fecha_remito = value; }
        public int Codigo_barra { get => codigo_barra; set => codigo_barra = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public double Total_remito { get => total_remito; set => total_remito = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }

    }
}
