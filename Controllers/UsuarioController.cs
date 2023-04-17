using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSemana5.Context;
using ProyectoSemana5.Models;

namespace ProyectoSemana5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly FachadaContext _dbContext;

        public UsuarioController(FachadaContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Usuarios);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            _dbContext.Add(usuario);
            _dbContext.SaveChanges();
            return Ok("Usuario Almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromServices] FachadaContext dbContext, long id, [FromBody] Usuario usuario)
        {
            var usuarioToUpdate = dbContext.Usuarios.Find(id);
            if (usuarioToUpdate == null)
            {
                return NotFound();
            }

            usuarioToUpdate.personaId = usuario.personaId;
            usuarioToUpdate.TipoServicioId = usuario.TipoServicioId;
            usuarioToUpdate.fechaIngreso = usuario.fechaIngreso;

            dbContext.SaveChanges();
            return Ok(usuarioToUpdate);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var usuario = _dbContext.Usuarios.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _dbContext.Remove(usuario);
            _dbContext.SaveChanges();
            return Ok("Usuario Eliminado");
        }
    }
}
