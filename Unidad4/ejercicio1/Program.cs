using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado = 0;
            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
            resultado = n1 - n2;}
            if(n1 == n2){
            resultado = n1 + n2;}
            if(n1 < n2){
            resultado = n1 * n2;}

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
