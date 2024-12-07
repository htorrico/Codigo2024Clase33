using Codigo2024Clase33.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
