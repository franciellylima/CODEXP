using System;

namespace Laço_While_com_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While com Array");
        
            string[] nomes = new string[3];

            // nomes[0] = "Carlos";
            // nomes[1] = "Carol";
            // nomes[2] = "André";

            // Console.WriteLine($"O nome na posição (1) é {nomes[1]}");

            int contador = 0;

            while(contador<3){
                Console.WriteLine($"Digite o {contador+1}° nome.");
                nomes[contador] = Console.ReadLine();
                contador++;
            }

            contador = 0;

            while(contador<3){
                Console.WriteLine($"O nome da {contador+1}° posição é {nomes[contador]}");
                contador++;
            }

            

        }
    }
}
