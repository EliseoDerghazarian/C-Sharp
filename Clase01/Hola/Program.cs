using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hola a todos!");
            Console.ReadKey();
            

            //Variables String
            string nombre;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

    

            //Console.WriteLine("El nombre igresado es {0}", nombre);
            Console.WriteLine("El nombre ingresado es " + nombre);
            Console.ReadKey();

            //Otro ejemplo
            string p, l, f;

            p = "perro";
            l = "ladra";
            f = "fuerte";

            Console.WriteLine("El {0} que {1} muy {2}", p, l, f);

            //Constantes
            const int diasSemana = 7;
            const int horasPorDia = 24;

            Console.WriteLine("La cantidad de horas de una semana es {0}", diasSemana * horasPorDia);
            Console.ReadKey();
            
            //Variables tipo int
            int a;
            a = 2;

            int b = 3;

            int c = a + b;

            Console.WriteLine("Variable a tiene {0}", a);
            Console.WriteLine("Variable b tiene {0}", b);
            Console.WriteLine("Variable c tiene {0}", c);
            Console.WriteLine("La suma de a y b es {0}", a + b + c);
       

            //Variables tipo char
            char char1 = 'Z';
            char char2 = (char)88; // Valor tabla ASCII convertido a char
            Console.WriteLine(char1 + " " + char2);
            Console.ReadKey();

            //Variables tipo boolean
            bool z;
            z = true;
            Console.WriteLine(z);
            z = false;
            Console.WriteLine(z);
            Console.ReadKey();
        
            //Variables tipo float
            float fl = 0;
            Console.WriteLine(fl);
            fl = 95.60f;
            Console.WriteLine(fl);

            //Variables tipo double
            double dl = 0;
            Console.WriteLine(dl);
            dl = 95.60d;
            Console.WriteLine(dl);
        

        }
    }
}
