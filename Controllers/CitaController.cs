using System;
using Microsoft.AspNetCore.Mvc;
using ProyectoSemana5.Context;
using ProyectoSemana5.Models;

namespace ProyectoSemana5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitaController : ControllerBase
    {
        private readonly FachadaContext _dbContext;

        public CitaController(FachadaContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Citas);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cita cita)
        {
            _dbContext.Add(cita);
            _dbContext.SaveChanges();
            return Ok("Cita Almacenada");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Cita cita)
        {
            var citaToUpdate = _dbContext.Citas.Find(id);
            if (citaToUpdate == null)
            {
                return NotFound();
            }

            citaToUpdate.usuarioId = cita.usuarioId;
            citaToUpdate.medicoId = cita.medicoId;
            citaToUpdate.fecha = cita.fecha;
            citaToUpdate.descripcion = cita.descripcion;

            _dbContext.SaveChanges();
            return Ok(citaToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var cita = _dbContext.Citas.Find(id);
            if (cita == null)
            {
                return NotFound();
            }

            _dbContext.Remove(cita);
            _dbContext.SaveChanges();
            return Ok("Cita Eliminada");
        }
    }
}
