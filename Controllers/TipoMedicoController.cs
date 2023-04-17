using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSemana5.Context;
using ProyectoSemana5.Models;

namespace ProyectoSemana5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoMedicoController : ControllerBase
    {
        private readonly FachadaContext _dbContext;

        public TipoMedicoController(FachadaContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.TipoMedicos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] TipoMedico tipoMedico)
        {
            _dbContext.Add(tipoMedico);
            _dbContext.SaveChanges();
            return Ok("Tipo de Médico Almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromServices] FachadaContext dbContext, int id, [FromBody] TipoMedico tipoMedico)
        {
            var tipoMedicoToUpdate = dbContext.TipoMedicos.Find(id);
            if (tipoMedicoToUpdate == null)
            {
                return NotFound();
            }

            tipoMedicoToUpdate.cargo = tipoMedico.cargo;

            dbContext.SaveChanges();
            return Ok(tipoMedicoToUpdate);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tipoMedico = _dbContext.TipoMedicos.Find(id);
            if (tipoMedico == null)
            {
                return NotFound();
            }

            _dbContext.Remove(tipoMedico);
            _dbContext.SaveChanges();
            return Ok("Tipo de Médico Eliminado");
        }
    }
}
