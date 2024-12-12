using Microsoft.CodeAnalysis.CSharp;

namespace Codigo2024Clase33.Requests
{     
    public class FacturaRequestV1
    {
        public DateTime Fecha { get; set; }
        public string Numero { get; set; }

        public decimal   Total { get; set; }

        public int ClienteID { get; set; }
    }
}
