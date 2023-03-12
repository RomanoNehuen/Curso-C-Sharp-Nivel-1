using System;

namespace ejercicio3
{
    class Program
    {
        //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
        //Hacer un programa para ingresar números. 
        //El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
        static void Main(string[] args)
        {
            int n, contadorprimos = 0, contadortotal = 0, promedioprimos;
            bool resultado;

            Console.WriteLine("Ingrese un numero :");
            n = int.Parse(Console.ReadLine());
            
            while (n !=0 && n > 0)
            {   
               contadortotal++; 
               resultado = primo(n);

               if(resultado == true)
               contadorprimos++;
                
                Console.WriteLine("Ingrese un numero :");
                n = int.Parse(Console.ReadLine()); 
            }
                promedioprimos = contadortotal / contadorprimos;

                Console.WriteLine("El promedio de numeros primos es: " + promedioprimos);
        }

        
        
        
        static bool primo(int n){
            
            int contador = 0;
            
            for(int x = 1; x <= n; x++){
               
                if(n % x == 0)
                contador++;
            }

            if(contador == 2)
            
            return true;
            else
            return false;
           
                
           

        }
    }

    

}
