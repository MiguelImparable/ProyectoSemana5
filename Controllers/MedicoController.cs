using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProyectoSemana5.Context;
using ProyectoSemana5.Models;

namespace ProyectoSemana5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicoController : ControllerBase
    {
        private readonly FachadaContext _dbContext;

        public MedicoController(FachadaContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Medicos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Medico medico)
        {
            _dbContext.Add(medico);
            _dbContext.SaveChanges();
            return Ok("Medico almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Medico medico)
        {
            var medicoToUpdate = _dbContext.Medicos.Find(id);
            if (medicoToUpdate == null)
            {
                return NotFound();
            }

            medicoToUpdate.personaId = medico.personaId;
            medicoToUpdate.tipoMedicoId = medico.tipoMedicoId;
            medicoToUpdate.fechaContrato = medico.fechaContrato;

            _dbContext.SaveChanges();
            return Ok(medicoToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var medico = _dbContext.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }

            _dbContext.Remove(medico);
            _dbContext.SaveChanges();
            return Ok("Medico eliminado");
        }
    }
}
