﻿using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
           //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            
            int n = 1, contador = 0;
        
           while(n >= 0){
            
            Console.WriteLine("ingrese numero: ");
            n = int.Parse(Console.ReadLine());
            contador = 0;
            
            while(n > 0){

                contador++;


                Console.WriteLine("ingrese numero: ");
                n = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("La lista tiene: " + contador + " numeros");
           }
          
        }
    }
}
