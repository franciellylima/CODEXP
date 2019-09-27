using System;

namespace mediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string resultado;
            string nome;
            float nota1;
            float nota2;
            float media;
            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua nota 1");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua nota 2");
            nota2 = float.Parse(Console.ReadLine());
            media = (nota1+nota2)/2;
            if (media>=7){
                resultado = "Aprovado";
            }else{
                resultado = "Reprovado";
            }

            Console.WriteLine($"{nome}, você foi {resultado}.");
        }

    }
}
