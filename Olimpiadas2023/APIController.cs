using Microsoft.AspNetCore.Mvc;
using Olimpiadas2023.Models.Personales;

namespace Olimpiadas2023
{
    [ApiController]
    [Route("[controller]")]
    public class ProyectoAController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Datos desde ProyectoA";
        }
    }
}
