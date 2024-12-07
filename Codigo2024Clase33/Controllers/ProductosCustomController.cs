using Codigo2024Clase33.Models;
using Codigo2024Clase33.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Codigo2024Clase33.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductosCustomController : ControllerBase
    {
        private readonly DemoContex _context;

        public ProductosCustomController(DemoContex context)
        {
            _context = context;
        }

        [HttpPost]
        public bool Insertar(ProductoRequestV1 request)
        {
            try
            {
                //Convertir mi request a mi modelo
                Producto producto = new Producto
                {
                    Nombre = request.Nombre,
                    Descripcion = request.Descripcion,
                    Precio = request.Precio,
                    Activo = true
                };


                _context.Productos.Add(producto);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        [HttpPut]
        public bool ActualizarPrecio(ProductoRequestV2 request)
        {
            try
            {
                var producto = _context.Productos.Find(request.Id);
                
                producto.Precio = request.Precio;
                
                _context.Entry(producto).State = EntityState.Modified;

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
