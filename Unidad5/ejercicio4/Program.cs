using System;

namespace ejercicio4
{
    class Program
    {
        //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo 
        //es primo o no es primo.  
        //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
        
        static void Main(string[] args)
        {
            int numero, contador = 0;
            Console.WriteLine("ingrese num: ");
            
            numero = int.Parse(Console.ReadLine());

            for(int x = 1; x <= numero; x++){
                if(numero % x == 0)
                contador++;
            }
            
            if(contador == 2)
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
            
            
        }
    }
}
