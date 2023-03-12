using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {  
          
          
          int[] numeros = new int[10];
          int n;      
              
                for (int x = 0; x < 10; x++)
          {
            Console.WriteLine("ingrese un numero: " );
            n = int.Parse(Console.ReadLine());
            numeros[x] = n;
          }

            int maximo = numeros[0];
            int pos = 1;
                
                for (int x = 0; x < 10; x++)
          {
            if(numeros[x] > maximo){
            maximo = numeros[x];
            pos = x + 1;
            }

          }

          Console.WriteLine("El maximo numero es: " + maximo + " Y su posicion es: " + pos);
           



        }
    }
}
