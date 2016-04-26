using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbonacci
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            List<int> fibonacci = new List<int>();
            fibonacci.Add(0);
            fibonacci.Add(1);

            Console.WriteLine("Serie de fibonnaci");
            Console.WriteLine(fibonacci[0]);
            Console.WriteLine(fibonacci[1]);
            for (int i=2; i < 100; i++)
            {
                fibonacci.Add(fibonacci.ElementAt(i-1)+ fibonacci.ElementAt(i-2));
                Console.WriteLine(fibonacci[i]);



            } Console.ReadLine();

        }
    }
}
