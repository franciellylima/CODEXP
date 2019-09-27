using System;

namespace Cálculo_de_média
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variável sempre com letra minuscula
            int n1,n2,n3;
            float media;

            Console.WriteLine("Digite a sua primeira nota");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua segunda nota");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua terceira nota");
            n3 = int.Parse(Console.ReadLine());

            // soma = n1+n2+n3;
            // media = soma/3;

            //método cast para converter o tipo de varirável desejável a um determinado objeto
            media = (float) (n1+n2+n3)/3;
            

            // Console.WriteLine($"A sua média é: {media}");
            // object sifrão significa interpolação
            Console.WriteLine($"A sua média é de: {media} ");

        }
    }
}
