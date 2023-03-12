using System;

namespace ejercicio2
{
    class Program
    {

        //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
        //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
        
        static void Main(string[] args)
        {   
            int n, contador = 0;
            bool resultado;
            
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("ingrese un numero");
                n = int.Parse(Console.ReadLine());
                
                resultado = par(n);
                
                if(resultado)
                contador++; 
            }
           
           Console.WriteLine(contador + " son pares");
        }

        static bool par(int n){
                
                if(n % 2 == 0)
                return true;
                
                else
                return false;
                
        }
    }
}
