using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)///Ingreso un valor que es comparado con un maximo y minimo, para validar que este dentro de los parametros.
        {
            if(valor > min && valor < max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
