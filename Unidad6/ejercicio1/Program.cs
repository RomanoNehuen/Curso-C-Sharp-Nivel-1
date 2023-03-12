using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {    //2, 3, 5, 7, 11, 13, 17, 19, 23, 29
            //1. Hacer un programa para ingresar 10 números. 
            //El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            
            int n, contador = 0, conprimos = 0;
            for(int x = 0; x < 10; x++){

                Console.WriteLine("ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                 
                 contador = 0;
                 
            for(int y = 1; y <= n; y++){
                if(n % y == 0)
                contador++;
            }

                if(contador == 2)
                conprimos++;

            }

            Console.WriteLine("Son primos: " + conprimos + " numeros");
            
            
        }
    }
}
