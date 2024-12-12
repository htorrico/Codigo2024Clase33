using Microsoft.Build.Evaluation;

namespace Codigo2024Clase33.Models
{
    public class Detalle
    {
        public int DetalleID { get; set; }
        public string PrecioVenta { get; set; }
        public int Cantidad { get; set; }


        //llamando las llaves foráneas.
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }

    }
}
