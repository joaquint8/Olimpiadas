using Olimpiadas2023.Enum;

namespace Olimpiadas2023.Models.Sesiones
{
    public class Rol
    {
        public int RolId { get; set; }
        public TipoRol Nombre { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
