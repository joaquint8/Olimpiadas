namespace Olimpiadas2023.Models.Sesiones
{
    public class Rol
    {
        public int RolId { get; set; }
        public string Nombre { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
