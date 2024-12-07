using Codigo2024Clase33.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Codigo2024Clase33.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientesCustomController : ControllerBase
    {
        private readonly DemoContex _context;

        public ClientesCustomController(DemoContex context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Cliente> Listar()
        {
            return _context.Clientes.Where(x=>x.Activo==true).ToList();
        }


        [HttpGet]
        public Cliente BuscarPorID(int Id)
        {
            //return _context.Clientes.Where(x => x.ClienteID == Id).FirstOrDefault();
            return _context.Clientes.Find(Id);
        }

        [HttpPost]
        public bool Insertar(Cliente cliente)
        {
            try
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }


        [HttpPut]
        public bool Actualizar(Cliente cliente)
        {
            try
            {                                
                _context.Entry(cliente).State = EntityState.Modified;            
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        [HttpDelete]
        public bool Eliminar(int id)
        {
            try
            {
                var cliente = _context.Clientes.Find(id);
                cliente.Activo = false;
                _context.Entry(cliente).State = EntityState.Modified;         
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        [HttpDelete]
        public bool EliminarFisica(int id)
        {
            try
            {
                var cliente =  _context.Clientes.Find(id);
                _context.Remove(cliente);
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
