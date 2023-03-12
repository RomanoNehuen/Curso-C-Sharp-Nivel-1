using System;

namespace ejercicio3cursogratis
{
    class Program
    {
        static void Main(string[] args)
        {
            int encomienda = 0, pesocamion = 0, numerocamion = 0;
            
            Console.WriteLine("Ingrese peso de la encomienda: ");
            encomienda = int.Parse(Console.ReadLine());
            
            while(encomienda > 0){
                numerocamion++;
                pesocamion = 0;
                
                while(encomienda + pesocamion <= 200){

                    pesocamion += encomienda;
                    
                    


                    Console.WriteLine("Ingrese peso de la encomienda: ");
                    encomienda = int.Parse(Console.ReadLine());
                }// FIN WHILE INTERNO
                     Console.WriteLine("El peso total del camion es: " + pesocamion );
                     Console.WriteLine(" El numero de camion es: " + numerocamion);



            } // FIN WHILE GENERAL
        }
    }
}
