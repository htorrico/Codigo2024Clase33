using Codigo2024Clase33.Models;
using Codigo2024Clase33.Requests;
using Codigo2024Clase33.Responses;
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

        [HttpGet]
        public List<ProductoResponseV1> ListarProductosStock()
        {
           
            var productos= _context.Productos.ToList();

            var response = productos.Select(x => new ProductoResponseV1
            {
                Nombre = x.Nombre,
                Stock = x.Stock
            }).ToList();

            return response;
        }


        [HttpGet]
        public List<ProductoResponseV2> ListarProductosFechaVencimiento()
        {

            var productos = _context.Productos.ToList();

            var response = productos.Select(x => new ProductoResponseV2
            {
                Nombre = x.Nombre,
                FechaNacimiento = x.FechaVencimiento
            }).ToList();

            return response;
        }


        

        [HttpPost]
        public ResponseBase Insertar(ProductoRequestV1 request)
        {
            ResponseBase response = new ResponseBase();

            try
            {
                //Convertir mi request a mi modelo
                Producto producto = new Producto
                {
                    Nombre = request.Nombre,
                    Descripcion = request.Descripcion,
                    Precio =Convert.ToDecimal( request.Precio),
                    Activo = true
                };

                _context.Productos.Add(producto);
                _context.SaveChanges();
                
                response.Mensaje = "Registro Exitoso";
                response.CodigoError = 0;

            }
            catch (Exception ex)
            {

                response.Mensaje = ex.ToString();
                response.CodigoError = -100;
            }
            return response;

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

        [HttpPut]
        public bool ActualizarStock(ProductoRequestV3 request)
        {
            try
            {
                var producto = _context.Productos.Find(request.Id);

                producto.Stock = request.Stock;

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
