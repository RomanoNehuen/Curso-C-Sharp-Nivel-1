using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int proce, ram, total = 0, disco;
            
            Console.WriteLine("Opcion de proce");
            proce = int.Parse(Console.ReadLine());
            Console.WriteLine("Opcion de ram");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Amplia disco?");
            disco = int.Parse(Console.ReadLine());
           
           switch(proce){
            case 1:
            switch(ram){
                case 1: total = 800;
                break;
                case 2: total = 900;
                break;
                case 3: total = 1000;
                break;
                default:
                Console.WriteLine("No coincide con ninguna opcion");
                break;
            }
            break;
            
            case 2:
            switch(ram){
                case 1: total = 900;
                break;
                case 2: total = 1000;
                break;
                case 3: total = 1400;
                break;
                default:
                Console.WriteLine("No coincide con ninguna opcion");
                break;
    
            }
            break;

            case 3:
            switch(ram){
                case 1: total = 1200;
                break;
                case 2: total = 1400;
                break;
                case 3: total = 2000;
                break;
                default:
                Console.WriteLine("No coincide con ninguna opcion");
                break;
            }
            break;
            
                default:
                Console.WriteLine("No coincide con ninguna opcion");
                break;
           }
           if(disco == 1)
            total = total + 300;
           else if(disco == 0)
            total = total;
           
           Console.WriteLine("El valor de la pc es: " + total);
        }
    }
}
