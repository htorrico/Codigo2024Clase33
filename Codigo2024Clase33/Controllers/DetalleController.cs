using Codigo2024Clase33.Models;
using Codigo2024Clase33.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codigo2024Clase33.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {

        private readonly DemoContex _context;

        public DetalleController(DemoContex context)
        {
            _context = context;
        }

        [HttpPost]
        public bool Insertar(DetalleRequestV1 request)
        {
            try
            {
                Detalle detalle = new Detalle
                {
                     PrecioVenta=request.PrecioVenta,
                      Cantidad= request.Cantidad,
                       ProductoID= request.ProductoID,

                };


                _context.Detalles.Add(detalle);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }


        //1.Listar todos los detalles donde el precio venta este entre 2 valores
        //2.Listar todos los detalles donde subtotal>Valor,
        //Subtotal= PrecioVenta*Cantidad

    }
}
