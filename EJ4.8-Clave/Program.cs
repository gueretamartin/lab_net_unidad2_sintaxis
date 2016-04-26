using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clave
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string clave = "martin";
            Boolean claveC = false;
            Console.WriteLine("Introduzca la clave");
            for( int intentos = 0; intentos < 4; intentos++) { 

                string claveIntroducida = Console.ReadLine();
                if (claveIntroducida == clave) {
                    claveC = true;
                    break;
                }
                Console.Clear();
                Console.WriteLine("Vuelva a introducir la clave");
            }
            if (claveC == true)
            {
                Console.WriteLine("Clave Correcta");

            } else { Console.WriteLine("Clave Incorrecta");  }
            Console.ReadKey();
        }
    }
}
