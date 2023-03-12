using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float venta, litros, total = 0;

            Console.WriteLine("Ingrese la venta total: ");
            venta = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los litros totales vendidos: ");
            litros = float.Parse(Console.ReadLine());

            if(litros > 500){
            total = venta * 0.75F;
             }
             else if(litros > 301 && litros < 500){
                total = venta * 0.85F;
             }
             else if(litros > 101 && litros < 300){
                total = venta * 0.90F;
            }
            else if(litros < 100){
                Console.WriteLine("No hay descuento");
            }

            Console.WriteLine("El total a pagar es: " + total);
            
            
        }
    }
}
