using System;

namespace Verificaçao_de_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            Console.WriteLine("Digite seu e-mail");
            email = Console.ReadLine();

            while (!email.Contains("@") || !email.Contains(".com")){
                Console.WriteLine("Digite seu e-mail corretamente");
                email = Console.ReadLine();

            }
            

        }
    }
}
