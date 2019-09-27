using System;

namespace Calculo_médias_e_faltas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            int faltas;
            double media;

            Console.WriteLine("App Cálculo de Média e faltas");
            Console.WriteLine("Bem vindo a Escola SENAI de Informática");
            Console.WriteLine("Digite a primeira nota");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de faltas");
            faltas = int.Parse(Console.ReadLine());

            media = (nota1+nota2)/2;

            if(media>=5 && faltas<=30){
                Console.WriteLine("Parabéns você foi Aprovado");
            
            }else{
                Console.WriteLine("Parabéns você foi Reprovado");
            }
        }
    }
}
