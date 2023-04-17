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
            //***DATOS INICIALES PARA LA BASE DE DATOS***************************************************************************************
            var datosServices = new DatosServices();
            datosServices.InsertarPersona(dbContext, "Miguel Angel Diaz Delgado", 1214743715, "3245718769", "Carrera24 No. 47-71");
            datosServices.InsertarPersona(dbContext, "Libny Merary Gualdron Hernandez", 999, "3245867571", "Carrera24 No. 47-71");
            datosServices.InsertarPersona(dbContext, "Laura Valentina Diaz Gualdron", 888, "000", "Carrera24 No. 47-71");
            datosServices.InsertarPersona(dbContext, "Andres Sanchez", 1234567890, "3006322035", "Calle 10 Transversal Superior");
            datosServices.InsertarPersona(dbContext, "FranK Castro", 0987654321, "3003000808", "Calle 52 No. 43 - 52 - 601");
            datosServices.InsertarTipoServicio(dbContext, "Plan Complementario");
            datosServices.InsertarTipoServicio(dbContext, "Plan Base");
            datosServices.InsertarTipoServicio(dbContext, "Mensualidad Particular");
            datosServices.InsertarTipoMedico(dbContext, "Medico General");
            datosServices.InsertarTipoMedico(dbContext, "Especialista Pediatria");
            datosServices.InsertarTipoMedico(dbContext, "Especialista Deportologo");
            datosServices.InsertarTipoMedico(dbContext, "Medico Cirujano");
            datosServices.InsertarUsuario(dbContext, 1, 2);
            datosServices.InsertarUsuario(dbContext, 2, 3);
            datosServices.InsertarUsuario(dbContext, 3, 1);
            datosServices.InsertarMedico(dbContext, 4, 2, new DateTime(2008, 5, 1, 8, 30, 52));
            datosServices.InsertarMedico(dbContext, 5, 3, new DateTime(2008, 5, 1, 8, 30, 52));
            datosServices.InsertarCita(dbContext, 3, 1, new DateTime(2023, 4, 17, 10, 00, 00), "Cita Anual de evaluacion de crecimiento y desarrollo");
            datosServices.InsertarCita(dbContext, 1, 2, new DateTime(2023, 4, 25, 12, 00, 00), "Dolor En la rodilla");
            //********************************************************************************************************************************
            return Results.Ok("Base de Datos en Memoria y con Datos Iniciales");
        }
    }
}