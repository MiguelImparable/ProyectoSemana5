using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSemana5.Context;
using ProyectoSemana5.Models;

namespace ProyectoSemana5.Services
{
    public class DatosInicialesServices
    {
        public void InsertarDatosNuevosSQL(FachadaContext dbContext)
        {
            Persona persona = new Persona()
            {
                
            };
            dbContext.Add(persona);
            dbContext.SaveChanges();
        }
    }
}


