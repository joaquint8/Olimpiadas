using Olimpiadas2023.Enum;

namespace Olimpiadas2023.ViewModels
{
    public abstract class PersonaViewModel
    {
            public int PersonaId { get; set; }
            //public TipoPersona TipoPersonas { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Direccion { get; set; }
            public string Documento { get; set; }
            public TipoGrupoSanguineo GrupoSanguineo { get; set; }
            public string Telefono { get; set; }

        
    }

}
