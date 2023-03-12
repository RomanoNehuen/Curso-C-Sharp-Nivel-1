using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("ingrese num 1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num 2");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num 3");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num 4");
            n4 = int.Parse(Console.ReadLine());
            
            if(n1 > n2 && n2 > n3 && n3 > n4)
                Console.WriteLine("Estan ordenados de manera decreciente");
                
            else
                Console.WriteLine("NO estan ordenados de manera decreciente");
            
        }
    }
}
