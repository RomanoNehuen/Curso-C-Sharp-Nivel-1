using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Hacer un programa que solicite 20 números y 
            //luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            
            int n, maxpar = 0, minimpar = 1;
            for(int x = 0; x < 20; x++){

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){
                    if(n > maxpar)
                        maxpar = n;
                   
                }else if(n < minimpar){
                    minimpar = n;
                    }
                }
                Console.WriteLine("el mayor de los pares es: " + maxpar);
                Console.WriteLine("el menor de los impares es: " + minimpar);
        }
            }
            
            
    }

