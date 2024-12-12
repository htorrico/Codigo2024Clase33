using Codigo2024Clase33.Models;
using Codigo2024Clase33.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codigo2024Clase33.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {

        private readonly DemoContex _context;

        public FacturaController(DemoContex context)
        {
            _context = context;
        }

        [HttpPost]
        public bool Insertar(FacturaRequestV1 request)
        {
            try
            {
                Factura factura = new Factura
                {
                    ClienteID = request.ClienteID,
                    Fecha = request.Fecha,
                    Numero = request.Numero,
                    Total = request.Total
                };


                _context.Facturas.Add(factura);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
