using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSemana5.Context;

namespace ProyectoSemana5.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class ConexionController : ControllerBase
    {
        [HttpGet(Name = "Conexion")]
        public IResult Get([FromServices] FachadaContext dbContext)
        {
            dbContext.Database.EnsureCreated();
            return Results.Ok("DB in Memory");
        }
    }
}