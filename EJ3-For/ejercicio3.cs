using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 5 valores que luego se mostrarán");
            int cantIteraciones=5;
            string[] array = new String[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++)
            {
                array[i] = Console.ReadLine();
            }
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
