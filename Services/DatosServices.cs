using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSemana5.Context;
using ProyectoSemana5.Models;

namespace ProyectoSemana5.Services
{
    public class DatosServices
    {
        public void InsertarPersona(FachadaContext dbContext, string nombreMADD, long cedulaMADD, string cedularMADD, string direccionMADD)
        {
            var nuevaPersona = new Persona()
            {
                nombre = nombreMADD,
                cedula = cedulaMADD,
                celular = cedularMADD,
                direccion = direccionMADD
            };
            dbContext.Add(nuevaPersona);
            dbContext.SaveChanges();
        }

        public void InsertarTipoServicio(FachadaContext dbContext, string descripcionMADD)
        {
            var nuevoServicio = new TipoServicio()
            {
                descripcionPlan = descripcionMADD
            };
            dbContext.Add(nuevoServicio);
            dbContext.SaveChanges();
        }

        public void InsertarTipoMedico(FachadaContext dbContext, string cargoMADD)
        {
            var nuevoTipoMedico = new TipoMedico()
            {
                cargo = cargoMADD
            };
            dbContext.Add(nuevoTipoMedico);
            dbContext.SaveChanges();
        }

        public void InsertarUsuario(FachadaContext dbContext, int personaIdMADD, int tipoServicioIdMADD)
        {
            var nuevoUsuario = new Usuario()
            {
                personaId = personaIdMADD,
                TipoServicioId = tipoServicioIdMADD,
                fechaIngreso = DateTime.Today
            };
            dbContext.Add(nuevoUsuario);
            dbContext.SaveChanges();
        }

        public void InsertarMedico(FachadaContext dbContext, int personaIdMADD, int tipoMedicoIdMADD, DateTime fechaMADD)
        {
            var nuevoMedico = new Medico()
            {
                personaId = personaIdMADD,
                tipoMedicoId = tipoMedicoIdMADD,
                fechaContrato = fechaMADD
            };
            dbContext.Add(nuevoMedico);
            dbContext.SaveChanges();
        }

        public void InsertarCita(FachadaContext dbContext, int usuarioIdMADD, int medicoIdMADD, DateTime fechaMADD, string descripcionMADD)
        {
            var nuevaCita = new Cita()
            {
                usuarioId = usuarioIdMADD,
                medicoId = medicoIdMADD,
                fecha = fechaMADD,
                descripcion = descripcionMADD
            };
            dbContext.Add(nuevaCita);
            dbContext.SaveChanges();
        }
    }
}


