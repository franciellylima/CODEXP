using System;

namespace Aprendendo_Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            Console.WriteLine(MensagemBoasVindas());
            Console.WriteLine("Aprendendo Funções");
            Console.WriteLine("Insira o primeiro número");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número");
            n2 = double.Parse(Console.ReadLine());
            double resultadoDaSoma = SomadeDoisNumeros(n1,n2);
            Console.WriteLine($"O resultado da soma é: {resultadoDaSoma}");
            // fim do main
            }
            //descrição de uma função
            /// <summary>Efetua a soma de dois números. </summary>
            /// <param name="a">Primeiro valor decimal. </param>
            /// <param name="b">Segundo valor decimal. </param>
            /// <returns>Retorna a soma dos dois números. </returns>
            public static double SomadeDoisNumeros(double a, double b){
                double soma = a + b;

                return soma;
            }
            ///<summary>Mostra um texto. </summary>
            /// <returns>Retorna o texto Bem vindo ao SENAI. </returns>
            public static string MensagemBoasVindas(){
                return "Bem vindo ao SENAI";
            }

    }
}
