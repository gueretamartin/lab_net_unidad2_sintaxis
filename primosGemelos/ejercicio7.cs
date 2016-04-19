using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primosGemelos
{
    class ejercicio7
    {
        static void Main(string[] args)
        {
            //7)	Calcular los N primeros números primos gemelos.

            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            Boolean divisibleporotro = false;
            int numeronuevo = numero ;
            for(int j=2; j <100; j=j+2){
                
                numeronuevo = numeronuevo + j ;
                for (int i = 2; i < numeronuevo; i++)
                        {
                            if ((numeronuevo % i) == 0) {
                                divisibleporotro = true;
                            }
                        Console.WriteLine(numeronuevo+" es no primo");
                        break;
                         }
             
            Console.WriteLine(numeronuevo+" es gemelo primo");
               
            
            
            
            
            
            
            }

          
            Console.WriteLine("Numero NO Primo");
            Console.ReadLine();






            }

        }
    }

