using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, menor;
            
            Console.WriteLine("ingrese num");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese num");
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2){
                menor = n1;
            }else{
                menor = n2;
                
            }if(n3 < menor){
                menor = n3;
            }if(n4 < menor){
                menor = n4;
            }
            Console.WriteLine("el menor es: " + menor);

            
            

        }
    }
}
