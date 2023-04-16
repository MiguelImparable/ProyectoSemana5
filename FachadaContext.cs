using Microsoft.EntityFrameworkCore;
using ProyectoSemana5.Models;

namespace ProyectoSemana5.Context
{
    public class FachadaContext : DbContext
    {
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<TipoMedico> TipoMedicos { get; set; }
        public DbSet<TipoServicio> TipoServicios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public FachadaContext(DbContextOptions<FachadaContext> options) : base(options) { }
    }
}

