using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSemana5.Context;
using ProyectoSemana5.Models;

namespace ProyectoSemana5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoServicioController : ControllerBase
    {
        private readonly FachadaContext _dbContext;

        public TipoServicioController(FachadaContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.TipoServicios);
        }

        [HttpPost]
        public IActionResult Post([FromBody] TipoServicio tipoServicio)
        {
            _dbContext.Add(tipoServicio);
            _dbContext.SaveChanges();
            return Ok("Tipo de Servicio Almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromServices] FachadaContext dbContext, int id, [FromBody] TipoServicio tipoServicio)
        {
            var tipoServicioToUpdate = dbContext.TipoServicios.Find(id);
            if (tipoServicioToUpdate == null)
            {
                return NotFound();
            }

            tipoServicioToUpdate.descripcionPlan = tipoServicio.descripcionPlan;

            dbContext.SaveChanges();
            return Ok(tipoServicioToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tipoServicio = _dbContext.TipoServicios.Find(id);
            if (tipoServicio == null)
            {
                return NotFound();
            }

            _dbContext.Remove(tipoServicio);
            _dbContext.SaveChanges();
            return Ok("Tipo de Servicio Eliminado");
        }
    }
}
