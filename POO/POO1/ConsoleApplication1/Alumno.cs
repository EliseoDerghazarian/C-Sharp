using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Alumno
    {
        int dNI;

        /* 
        VERSION 1
        public void SetDNI(int valor)
        {
            dNI = valor;
        }

        public int GetDNI()
        {
            return dNI;
        }
        
        VERSION 2
        public int DNI
        {
            set { dNI = value; }
            get { return dNI; }
        }
        */

        //VERSION FINAL
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string traerDatos()
        {
            return "DNI: " + DNI + " Nombre: " + Nombre + " Apellido: " + Apellido;
        }

        public int traerEdad()
        {
            return DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;
        }

        //Constructor
        public Alumno()
        {
            Console.WriteLine("Hola soy el constructor sin parámetros!");
        }

        //Sobrecarga de constructores
        public Alumno(string nombre)
        {
            Console.WriteLine("Hola soy el constructor con 1 parámetro!");
            Nombre = nombre;
        }

        public Alumno(string nombre, string apellido)
        {
            Console.WriteLine("Hola soy el constructor con 2 parámetros!");
            Nombre = nombre;
            Apellido = apellido;
             
        }

    }
}
