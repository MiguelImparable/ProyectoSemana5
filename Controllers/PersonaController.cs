using Microsoft.AspNetCore.Mvc;
using ProyectoSemana5.Context;
using ProyectoSemana5.Models;
namespace ProyectoSemana5.Controllers;
[ApiController]
[Route("[controller]")]
public class PersonaController : ControllerBase
{
    private readonly FachadaContext _dbContext;

    public PersonaController(FachadaContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("{id?}")]
    public IActionResult Get(long id)
    {
        if (id == 0)
        {
            return Ok(_dbContext.Personas);
        }
        else
        {
            var persona = _dbContext.Personas.Find(id);
            if (persona == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(persona);
            }
        }
    }

    [HttpPost]
    public IActionResult Post([FromBody] Persona persona)
    {
        _dbContext.Add(persona);
        _dbContext.SaveChanges();
        return Ok(_dbContext.Personas);
    }

    [HttpPut("{id}")]
    public IActionResult Put([FromServices] FachadaContext dbContext, long id, [FromBody] Persona persona)
    {
        var personaToUpdate = dbContext.Personas.Find(id);
        if (personaToUpdate == null)
        {
            return NotFound();
        }
        personaToUpdate.nombre = persona.nombre;
        personaToUpdate.cedula = persona.cedula;
        personaToUpdate.celular = persona.celular;
        personaToUpdate.direccion = persona.direccion;
        dbContext.SaveChanges();
        return Ok(_dbContext.Personas);
    }


    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        var persona = _dbContext.Personas.Find(id);
        if (persona == null)
        {
            return NotFound();
        }

        _dbContext.Remove(persona);
        _dbContext.SaveChanges();
        return Ok(_dbContext.Personas);
    }
}
