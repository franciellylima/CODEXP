using System;

namespace Tabueada_com_Laço_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada com Laço FOR");
            Console.WriteLine("Qual tabuada deseja saber?");

            float tabuada = float.Parse(Console.ReadLine());

            for(int contador = 0; contador <= 10; contador++){
                Console.WriteLine($"{tabuada} X {contador} = {tabuada*contador}");
            }
        }
    }
}
