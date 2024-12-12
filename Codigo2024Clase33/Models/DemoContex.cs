using Microsoft.EntityFrameworkCore;

namespace Codigo2024Clase33.Models
{
    public class DemoContex: DbContext
    {     
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Detalle> Detalles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                "Database=Codigo2024DB2; Integrated Security=True;" +
                "Trust Server Certificate=True ");
        }
    }
}
