using System;

namespace Foreach_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            nomes[0] = "Carlos";
            nomes[1] = "Ronaldo";

            foreach(var item in nomes){
                if(!string.IsNullOrEmpty(item)){
                    Console.WriteLine(item);
                }
            }

            int[] numeros = new int [10];
            numeros[0] = 100;
            numeros[1] = 200;

            foreach (var item in numeros){
                if(item != 0){
                    Console.WriteLine(item);
                }
            }
        }
    }
}
