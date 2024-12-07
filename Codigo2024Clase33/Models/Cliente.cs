using Microsoft.EntityFrameworkCore;

namespace Codigo2024Clase33.Models
{
    public class Cliente
    {
        
        public int ClienteID { get; set; }

        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public bool Activo { get; set; }
    }
}
