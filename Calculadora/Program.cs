using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
     // EJERCICIO 1
     //int n1, n2, resultado;
     //Console.WriteLine("ingrese un numero:");
     //n1 = int.Parse(Console.ReadLine());
     //Console.WriteLine("ingrese otro");
     //n2 = int.Parse(Console.ReadLine());
     //resultado = n1 + n2;
     //Console.WriteLine("el resultado es:" + resultado);
// EJERCICIO 2
//int n1, resultado;
//Console.WriteLine("ingrese un numero");
//n1 = int.Parse(Console.ReadLine());
//resultado = n1 * n1 * n1;
//Console.WriteLine("el resultado es:" + resultado);
// EJERCICIO 3
float kilometros, velocidad, Tiempo;
Console.WriteLine("ingrese la distancia");
kilometros = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese la velocidad");
velocidad = float.Parse(Console.ReadLine());
Tiempo = kilometros / velocidad;
Console.WriteLine("Tiempo estimado de llegada: " + Tiempo.ToString("0.00"));
     

    
     
        }
    }
}
