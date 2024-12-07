namespace Codigo2024Clase33.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public int Stock { get; set; }


        public bool Activo { get; set; }
    }
}
