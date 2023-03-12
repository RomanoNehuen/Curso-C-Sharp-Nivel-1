using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, n;
            
            for(int x = 0; x < 10; x++)
            {
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            if(x == 0)
            max = n;
            else{
            
            if(n > max)
            max = n;
            }
            }
            
            Console.WriteLine("el maximo es: " + max);
        }
    }
}
