using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
           //Se pide determinar e informar:

            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            
            int n, contadorordenado = 0, contadortotal, contadorimpar, numerogrupo = 0, mayor;
            double porcentaje = 0, porcentajemax = -1;
             
             for(int x = 0; x < 5; x++){
                
                contadortotal = 0;
                contadorimpar = 0;
                
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
               
                mayor = n;
                 bool bandera = true;

                while( n != 0){
                    
                    contadortotal++;
                    
                    if(n % 2 !=0)
                        contadorimpar++;
                
                    if(n <= mayor)
                    mayor = n;
                    else
                    bandera = false;

                
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                } // FIN DEL WHILE
                
                porcentaje = contadortotal * 100 / contadorimpar;
                
                if(porcentaje > porcentajemax){
                porcentajemax = porcentaje;
                numerogrupo = x + 1;
                }
                if(bandera == true)
                contadorordenado++;

            } // FIN DEL FOR

            Console.WriteLine("El número de grupo con mayor porcentaje de números impares es: " + numerogrupo);
            Console.WriteLine("La cantidad de grupos con numeros ordenados es: " + contadorordenado);
        }

    }
}
