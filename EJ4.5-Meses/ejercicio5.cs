using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meses
{
    class ejercicio5
    {
        static void Main(string[] args)
        {
        List<string> meses = new List<string>(); 
            meses.Add("Enero");
            meses.Add("Febrero");
            meses.Add("Marzo");
            meses.Add("Abril");
            meses.Add("Mayo");
            meses.Add("Junio");
            meses.Add("Julio");
            meses.Add("Agosto");
            meses.Add("Septiembre");
            meses.Add("Octubre");
            meses.Add("Noviembre");
            meses.Add("Diciembre");
            Console.WriteLine("Ingrese el numero del mes");
            int numeroMes = int.Parse(Console.ReadLine());
            Console.WriteLine(meses.ElementAt(numeroMes-1));
            Console.ReadLine();

        }
    }
}
