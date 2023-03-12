using System;

namespace ejercicio4
{
    class Program
    {   
        //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
        //que reciba un número por valor y una variable por referencia. Que analice el número 
        //y escriba variable recibida por referencia con:

        //a. 1 si el número es positivo.
        //b. -1 si el número es negativo.
        //c. 0 si el número es cero.
        
        static void Main(string[] args)
        {   
            int n;
            int variable = 2;
            
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            PositivoNegativoCero(n, ref variable);

            Console.WriteLine(variable);
        }

        static void PositivoNegativoCero(int n, ref int variable){

           
            if(n > 0)
            variable = 1;
            
            else if(n == 0)
            variable = 0;
            
            else
            variable = -1;


        }
    }
}
