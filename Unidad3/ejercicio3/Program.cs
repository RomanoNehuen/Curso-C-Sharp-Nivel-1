using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe, Valorfinal;
            Console.WriteLine("ingrese el importe: ");
            importe = float.Parse(Console.ReadLine());
            if(importe >5000){
             Valorfinal = importe * 0.82F;
             Console.WriteLine(("el importe a pagar es: ") + Valorfinal);
            }else if(importe > 1000 && importe < 5000){
            Valorfinal = importe * 0.90F;
            Console.WriteLine(("el importe a pagar es: ") + Valorfinal);
            }else if(importe < 1000){
                Console.WriteLine("No hay descuento: ");
            }

        }
    }
}
