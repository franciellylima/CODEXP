using System;

namespace Calculadora_de_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            float number;
            float result;
            Console.WriteLine("Digite um número para verificar a tabuada");
            number = float.Parse(Console.ReadLine());

            while(i<=10){
                result = (number)*(i);
                Console.WriteLine($"({number}) x ({i}) = ({result}) ");
                i++;

            }

        }
    }
}
