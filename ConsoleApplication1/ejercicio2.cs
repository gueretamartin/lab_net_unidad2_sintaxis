using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            var texto = Console.ReadLine();
            if (String.IsNullOrEmpty(texto))
            {
                Console.WriteLine("Error, cadena vacía ");

            }
            else
            {
                var rta = true;
                while (rta == true)
                {

                    Console.WriteLine("Ingrese la opción que desea realizar");
                    Console.WriteLine("1 - PASAR A MAYUSCULAS");
                    Console.WriteLine("2 - PASAR A MINUSCULAS");
                    Console.WriteLine("3 - MOSTRAR LONGITUD");
                    ConsoleKeyInfo opcion = Console.ReadKey();
                    Console.Clear();
                    switch (opcion.Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine(texto.ToUpper());
                            rta = false;
                            break;

                        case ConsoleKey.D2:
                            Console.WriteLine(texto.ToLower());
                            rta = false;
                            break;

                        case ConsoleKey.D3:
                            Console.WriteLine(texto.Length);
                            rta = false;
                            break;

                        default:
                            Console.WriteLine("Ingrese un valor correcto");
                            Console.Clear();
                            break;
                    }
                    Console.ReadKey();
                }

            }
        }
    }
}

