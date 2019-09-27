using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui é onde iremos inserior o código
            Console.WriteLine("Soma de dois números");
            
            // int n1;
            // int n2;

            Console.WriteLine("Digite o primeiro número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo número");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1+n2;

            Console.WriteLine($"O Resultado é: {resultado}"); //com o cifrão é possivel fazer a concatenação de uma string com uma variável
            // Console.WriteLine("O Resultado é: " + resultado); //Desta forma também funciona
        }
    }
}   
