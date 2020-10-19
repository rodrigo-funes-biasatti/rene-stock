using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Rene.Clases
{
    class DatosRecaudacion
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private int cantidadRemitosGenerados;
        private int productosVendidos;
        private double promedioRecaudacionPorDia;
        private double totalRecaudado;

        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
        public int CantidadRemitosGenerados { get => cantidadRemitosGenerados; set => cantidadRemitosGenerados = value; }
        public int ProductosVendidos { get => productosVendidos; set => productosVendidos = value; }
        public double PromedioRecaudacionPorDia { get => promedioRecaudacionPorDia; set => promedioRecaudacionPorDia = value; }
        public double TotalRecaudado { get => totalRecaudado; set => totalRecaudado = value; }
    }
}
