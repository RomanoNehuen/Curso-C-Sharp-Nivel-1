using System;

namespace ejercicio1
{
    class Program
    {

            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            //Luego hacer un programa que pida el precio de un artículo y 
            //la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

        static void Main(string[] args)
        {
            int valor, cantidad, total;
            
            Console.WriteLine("ingrese valor del producto");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida:");
            cantidad = int.Parse(Console.ReadLine());

            total = producto(valor, cantidad);
            
            Console.WriteLine("El total a pagar es: " + total);
            

            
        }

        static int producto(int a, int b){

            int precio;
            precio = a * b;
            return precio;

        }
    }
}
