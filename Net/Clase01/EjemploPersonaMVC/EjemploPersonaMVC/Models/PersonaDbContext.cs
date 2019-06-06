using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EjemploPersonaMVC.Models
{
    public class PersonaDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
    }
}