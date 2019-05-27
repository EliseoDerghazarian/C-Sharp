using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno("Pepe");
            Alumno alumno3 = new Alumno("Pepe", "Gomez");
            Console.WriteLine(alumno2.Nombre);
            Console.WriteLine($"El nombre es: {alumno3.Nombre} y el apellido es: {alumno3.Apellido}");
            /* 
            VERSION 1
            alumno1.dNI = 36903921;
            Console.WriteLine(alumno1.dNI);
            Console.WriteLine("El DNI del alumno es: {0}", alumno1.dNI);
            Console.WriteLine($"El DNI del alumno es: {alumno1.dNI}"); //Forma interpolada
            
            VERSION 2
            alumno1.SetDNI(36903921);
            Console.WriteLine($"El DNI del alumno es: {alumno1.GetDNI()}"); 
            */

            //Console.WriteLine($"El DNI del alumno es: {alumno1.DNI}");

            //VERSION FINAL
            alumno1.DNI = 36903921;
            alumno1.Nombre = "Eliseo";
            alumno1.Apellido = "Derghazarian";
            alumno1.FechaNacimiento = Convert.ToDateTime("21/04/1992");

            Console.WriteLine($"El DNI del alumno es: {alumno1.DNI}");
            Console.WriteLine($"El nombre y apellido del alumno es: {alumno1.Nombre} {alumno1.Apellido}");

            Console.WriteLine(alumno1.traerDatos());
            Console.WriteLine($"La edad del alumno es: {alumno1.traerEdad()}");
            Console.WriteLine("");

            //Alumno 2
            alumno2.DNI = 40000000;
            alumno2.Nombre = "Noelia";
            alumno2.Apellido = "Derghazarian";
            alumno2.FechaNacimiento = Convert.ToDateTime("20/11/1997");

            Console.WriteLine(alumno2.traerDatos());
            Console.WriteLine($"La edad del alumno es: {alumno2.traerEdad()}");



            Console.ReadKey();
        }
    }
}
