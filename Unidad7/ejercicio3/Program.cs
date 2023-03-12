using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] nombre = new char[11];
            char letra;
            int indice = 0;
            
            Console.WriteLine("Ingrese su nombre letra por letra: ");
            letra = char.Parse(Console.ReadLine());
            
            while(letra != '.' && indice < 10){
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
                nombre[indice] = '\0';

                for (int x = 0; x < 11; x++)
                {
                    if(nombre[x] == 'a' || nombre[x] == 'A' )
                    nombre[x] = 'e';
                }
                int indice2 = 0;
                
                Console.Write("Hola ");
                
                while(nombre[indice2] != '\0'){
                    
                    Console.Write(nombre[indice2]);
                    indice2++;
                    
                }
        }
    }
}
