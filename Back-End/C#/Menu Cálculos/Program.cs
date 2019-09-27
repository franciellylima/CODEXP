using System;

namespace Menu_Cálculos
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float n2;
            string choice;
            float result;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Menu Cálculos");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Digite um número");
            n1 = float.Parse((Console.ReadLine()));
            Console.WriteLine("");
            Console.WriteLine("Digite outro número");
            n2 = float.Parse((Console.ReadLine()));
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha agora uma das opções.");
            Console.WriteLine("");
            Console.WriteLine("( a ) Soma de números.");
            Console.WriteLine("( b ) Subtração do primeiro pelo segundo.");
            Console.WriteLine("( c ) Subtração do Segundo pelo primeiro.");
            Console.WriteLine("( d ) Multiplicação dos dois números.");
            Console.WriteLine("( e ) Divisão do primeiro pelo segundo.");
            Console.WriteLine("( f ) Divisão do segundo pelo primeiro.");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            choice = (Console.ReadLine());
            choice = choice.ToLower();//função para forçar o resultado ficar em minúsculo
            Console.WriteLine("");

            switch(choice){
                
                case "a":
                result = (n1)+(n2);
                Console.WriteLine($"O resultado é: {result}");
                Console.WriteLine("");
                break;

                case "b":
                result = (n1)-(n2);
                Console.WriteLine($"O resultado é: {result}");
                Console.WriteLine("");
                break;

                case "c":
                result = (n2)-(n1);
                Console.WriteLine($"O resultado é: {result}");
                Console.WriteLine("");
                break;

                case "d":
                result = (n1)*(n2);
                Console.WriteLine($"O resultado é: {result}");
                Console.WriteLine("");
                break;

                case "e":
                result = (n1)/(n2);
                Console.WriteLine($"O resultado é: {result}");
                Console.WriteLine("");
                break;

                case "f":
                result = (n2)/(n1);
                Console.WriteLine($"O resultado é: {result}");
                Console.WriteLine("");
                break;

                default:
                Console.WriteLine("Digite uma das opções válidas do menu.");
                Console.WriteLine("");
                break;

            }    
        }
    }
}
