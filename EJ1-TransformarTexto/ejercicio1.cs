using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            var texto = Console.ReadLine();
            if (String.IsNullOrEmpty(texto))
            {
                Console.WriteLine("Error, cadena vacía ");
              
            }
            else { 
            var rta =true;
             while(rta==true){

                Console.WriteLine("Ingrese la opción que desea realizar");
                Console.WriteLine("1 - PASAR A MAYUSCULAS");
                Console.WriteLine("2 - PASAR A MINUSCULAS");
                Console.WriteLine("3 - MOSTRAR LONGITUD");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.Clear();
                if(opcion.Key==ConsoleKey.D1)
                {
                  Console.WriteLine(texto.ToUpper());
                  rta = false;
                  break;
                }
                else if(opcion.Key==ConsoleKey.D2){
                  Console.WriteLine(texto.ToLower());
                  rta = false;
                  break;

                }
                else if (opcion.Key==ConsoleKey.D3) {
                  Console.WriteLine(texto.Length);
                  rta = false;
                  break;

                }
                else {Console.WriteLine("Ingrese un valor correcto");}
                Console.Clear();
                }
        Console.ReadKey();   
        }
        }
        }

            
         }
   
    
