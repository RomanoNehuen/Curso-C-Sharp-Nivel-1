using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, con = 0;
            Console.WriteLine("ingrese num");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > 100){
                
                Console.WriteLine( n1 + " Es mayor a 100 ");
                con++;
                }
                
                if(n2 > 100){
                    
                    Console.WriteLine("Es mayor a 100 ");
                    con++;
                    }

                    if(n3 > 100){
                        Console.WriteLine(n3 + " Es mayor a 100");
                        con++;
                    }
                    if(n4 > 100){
                        Console.WriteLine( n4 + " Es mayor a 100");
                        con++;
                    }

           
        }
    }
}
