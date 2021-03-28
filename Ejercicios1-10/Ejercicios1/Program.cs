using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string auxNumero;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            float promedio = 0;
            int ingresos = 5;
            int cantidad = 1;

            for(int i = 0; i < ingresos; i++ )
            {
                Console.WriteLine("Ingrese numero {0}", cantidad);
                auxNumero = Console.ReadLine();
                if(int.TryParse(auxNumero, out numero))
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    cantidad++;
                    promedio = promedio + numero;
                    
                }
                
            }
            promedio = promedio / ingresos;
            Console.WriteLine("El numero maximo es {0}\nEl numero minimo es {1}\nEl promedio es {2}\n", maximo, minimo, promedio);
            Console.ReadKey();
            

        }
    }
}
