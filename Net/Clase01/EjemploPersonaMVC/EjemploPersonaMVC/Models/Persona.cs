using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploPersonaMVC.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime  FechaNacimiento { get; set; }

    }
}