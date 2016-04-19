using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pensar
{
    class ejercicio41
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());
            int suma = numero1 + numero2;
            Console.WriteLine("El resultado de la suma de "+numero1+" y "+numero2+"es  "+suma);
            Console.ReadLine();
        }
    }
}
