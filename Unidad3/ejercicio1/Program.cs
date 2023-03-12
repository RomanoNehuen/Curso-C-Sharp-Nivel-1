using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Ingrese un numero: ");
            
            n1 = int.Parse(Console.ReadLine());
            
            if(n1 > 10) {Console.WriteLine("Es mayor");
            
            }else{
                Console.WriteLine("No es mayor");
            }
        }
    }
}
