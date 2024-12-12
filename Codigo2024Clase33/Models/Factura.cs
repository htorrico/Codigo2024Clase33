namespace Codigo2024Clase33.Models
{
    public class Factura
    {
        public int FacturaID { get; set; }
        public DateTime Fecha { get; set; }
        public string Numero { get; set; }

        public decimal Total { get; set; }

        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
    }
}
