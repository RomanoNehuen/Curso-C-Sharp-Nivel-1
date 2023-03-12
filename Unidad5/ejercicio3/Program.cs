using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, contador = 0, acumulador = 0, promedio;

            for(int x = 0; x < 20; x++)
            {

                Console.WriteLine("Ingresar edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18){
                    contador++;
                    acumulador += edad;
                }

            }
                promedio = acumulador / contador;

                Console.WriteLine("El promedio de edades es: " + promedio);
            
            
        }
    }
}
