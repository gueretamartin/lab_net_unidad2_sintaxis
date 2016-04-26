using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ejecicio42
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año");
            int año = int.Parse(Console.ReadLine());
            int divisiblePorCuatro = año%4;
            int divisiblePorCien = año%100;
            int divisiblePorCuatrosientos = año % 400;
            Boolean bisiesto = false;
            if (divisiblePorCuatro == 0 && divisiblePorCien==0 && divisiblePorCuatrosientos==0)
            {
                bisiesto = true; }

                else if (divisiblePorCuatro == 0 && divisiblePorCien ==0)
                {                                     
                    bisiesto = false;
                }
            else if(divisiblePorCuatro== 0)
            { bisiesto=true;}
            if(bisiesto==true)
            {
                Console.WriteLine("Año bisiesto");
            }
            else{Console.WriteLine("Año no bisiesto");}
            Console.ReadLine();
            }
        
        }
    }
