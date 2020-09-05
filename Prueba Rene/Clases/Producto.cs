namespace Prueba_Rene.Clases
{
    class Producto
    {
        private int id_prod;
        private string marca;
        private string nombre;
        private double precio_unitario;
        private string descripcion;
        private int id_rubro;

        public int Id_prod { get => id_prod; set => id_prod = value; }
        public string Marca { get => marca; set => marca = value; }
        public double Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id_rubro { get => id_rubro; set => id_rubro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
