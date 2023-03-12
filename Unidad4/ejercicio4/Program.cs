using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("ingrese num 1; ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num 2; ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num 3; ");
            n3 = int.Parse(Console.ReadLine());

            if((n1 + n2) > (n2 * n3))
                Console.WriteLine("Es mayor");
                else{
                    Console.WriteLine("No es mayor");
                }
                }
                
            

        }
    }

