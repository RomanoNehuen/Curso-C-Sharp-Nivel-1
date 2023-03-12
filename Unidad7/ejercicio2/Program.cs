using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int n;
            for (int x = 0; x < 10; x++)
            {
                Console.Write("Ingrese numero: ");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }
            int contador = 0, promedio;
            
            for (int x = 0; x < 10; x++)
            {
                contador += numeros[x];
            }
            promedio = contador / 10;
             
             Console.WriteLine("El promedio es: " + promedio);
            
            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > promedio)
                 Console.WriteLine("Son mayores al promedio: " + numeros[x]);
            }
           
           
        }
    }
}
