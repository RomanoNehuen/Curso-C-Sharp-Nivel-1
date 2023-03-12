using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.
            
            int articulo;
            int cantidad;
            int[] acumuladores = new int[5];
           

            Console.WriteLine("ingrese articulo");
            articulo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());
            
            for (int x = 0; x < 5; x++)
            {
                acumuladores[x] = 0;
            }
            
            while(articulo != 0){
                
                acumuladores[articulo - 1] += cantidad;
                
                Console.WriteLine("ingrese articulo");
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad vendida");
                cantidad = int.Parse(Console.ReadLine());
            }
                int maximo = acumuladores[0];
                int posicion = 1;
                //punto A
                
                for (int x = 0; x < 5; x++)
            {
                if(acumuladores[x] > maximo)
                maximo = acumuladores[x];
                posicion = x + 1;
                        
            }
             Console.WriteLine("El numero de articulo que mas se vendio es: " + posicion + " Con la cantidad de: " + maximo);
             
             // Punto B

             for (int x = 0; x < 5; x++)
                {
                     if(acumuladores[x] == 0)
                      Console.WriteLine("El producto no tuvo ventas: " + (x + 1));
                }
             
             // Punto C
             Console.WriteLine("Las ventas para el numero de articulo numero 5 son :" + acumuladores[4]);
        }
    }
}
