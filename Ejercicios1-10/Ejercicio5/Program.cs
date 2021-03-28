using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorHora;
            string nombre;
            double antiguedad;
            double horasTrabajadas;
            string lectura;
            double neto;
            double bruto;
            double descuento;
            double antiguedadPago;

            Console.WriteLine("Ingrese nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese valor de hora trabajada");
            lectura = Console.ReadLine();
            double.TryParse(lectura, out valorHora);
            Console.WriteLine("Ingrese antiguedad");
            lectura = Console.ReadLine();
            double.TryParse(lectura, out antiguedad);
            Console.WriteLine("Ingrese cantidad de horas trabajadas");
            lectura = Console.ReadLine();
            double.TryParse(lectura, out horasTrabajadas);

            bruto = valorHora * horasTrabajadas;
            antiguedadPago = antiguedad * 150;
            descuento = (((bruto + antiguedadPago) * 13) / 100);
            neto = bruto + antiguedadPago - descuento;

            Console.WriteLine("El empleado {0} \ncon antiguedad {1} años \ncon valor de hora {2}\ndebera tener un bruto de {3}\ncon descuentos de {4}\ny un neto en mano de {5}", nombre, antiguedad, valorHora, bruto, descuento, neto);
            Console.ReadKey();


            
           



        }
    }
}
