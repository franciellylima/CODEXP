using System;

namespace Meia_Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());

            if(idade<=18 || idade>=60){
                Console.WriteLine($"{nome}, você tem direito a meia entrada");

            }else{
                Console.WriteLine($"{nome}, você não tem direito a meia entrada");
            }
        }
    }
}
