using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            if (n1 > 0)
                Console.WriteLine("POSITIVO");
            else if (n1 < 0)
                Console.WriteLine("NEGATIVO");
            else if(n1 == 0)
                Console.WriteLine("ES CERO");
            
        }
    }
}
