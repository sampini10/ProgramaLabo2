using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            string lectura;
            double cuadrado;
            double cubo;
            do
            {
                Console.WriteLine("Ingrese el numero:");
                lectura = Console.ReadLine();
                if (double.TryParse(lectura, out numero) && numero > 0)
                {
                    cuadrado = Math.Pow(numero, 2);
                    cubo = Math.Pow(numero, 3); 
                    Console.WriteLine("El cuadrado de {0} es {1}", numero, cuadrado);
                    Console.WriteLine("El cubo de {0} es {1}", numero, cubo);
                }
                else
                {
                    Console.WriteLine("Error, reingrese el numero, recuerde que tiene que ser mayor que 0");
                }
            } while (numero <= 0);
            Console.ReadKey();
        }
    }
}
