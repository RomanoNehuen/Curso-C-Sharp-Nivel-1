using System;

namespace TPFinal_Romano
{
    class Program
    {
        static void Main(string[] args)
        {
                //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
                //A partir de dichos datos informar:

                // a. El mayor de los números pares.
                // b. La cantidad de números impares.
                // c. El menor de los números primos.

                // Nota: evaluar el uso de una función que analice si un número dado es primo o no 
                //y que devuelva true o false según corresponda.

                int n, contadorpares = 0, contadorimpares = 0, maximopar = 0, menorprimo = 0, contadortotalprimos = 0;
                bool resultadoprimo;
                
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                while (n != 0){
                    
                    if(n % 2 == 0){
                    contadorpares++;
                    
                    if(n > maximopar)
                    maximopar = n;

                    }
                    else
                    {
                        contadorimpares++;
                    }

                    resultadoprimo = primo(n);
                    
                    if(resultadoprimo){
                        
                        if(contadortotalprimos == 0){ 
                        menorprimo = n;
                        contadortotalprimos++;
                        }
                        else if(n < menorprimo)
                        menorprimo = n;
                    }
                    
                    
                    Console.WriteLine("Ingrese un numero: ");
                    n = int.Parse(Console.ReadLine());
                }
                
                if(maximopar != 0)
                Console.WriteLine("El mayor de los numeros pares es: " + maximopar);
                else
                Console.WriteLine("No se ingresaron numeros pares");
                
                if(contadorimpares != 0)
                Console.WriteLine("La cantidad de numeros impares es: " + contadorimpares);
                else
                Console.WriteLine("No se ingresaron numeros impares");

                if(contadortotalprimos != 0)
                Console.WriteLine("El menor de los numeros primos es: " + menorprimo);
                else
                Console.WriteLine("No se ingresaron numeros primos");
        }

        static bool primo(int n){
            int contador = 0;
            
            for (int x = 1; x <= n; x++)
            {
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