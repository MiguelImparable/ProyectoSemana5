using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSemana5.Context;
using ProyectoSemana5.Services;

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
            DatosInicialesServices datosInicialesServices = new DatosInicialesServices();
            datosInicialesServices.InsertarDatosNuevosSQL(dbContext);
            return Results.Ok("Base de Datos en Memoria y con Datos Iniciales");
        }
    }
}