using System;

namespace Aumento_de_Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double oldPaycheck;
            double newPaycheck;
            string choice;
            Console.WriteLine("");
            Console.WriteLine("Cálculo para aumento de salário");
            Console.WriteLine("");
            Console.WriteLine("Digite seu nome");
            name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Digite seu salário atual");
            oldPaycheck = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("CÓDIGO       |       CARGO");
            Console.WriteLine("_____________|____________________");
            Console.WriteLine("             |");
            Console.WriteLine("(1)          |       Escrituário");
            Console.WriteLine("(2)          |       Secretário");
            Console.WriteLine("(3)          |       Caixa");
            Console.WriteLine("(4)          |       Gerente");
            Console.WriteLine("(5)          |       Diretor");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            choice = Console.ReadLine();
            Console.WriteLine("");
            switch(choice){

                case "1":
                newPaycheck = (double) ((oldPaycheck*0.5) + oldPaycheck);
                Console.WriteLine($"NOME: {name}  |  SALÁRIO: R${oldPaycheck}  |  CÓDIGO: {choice}  |  CARGO: Escrituário  |  PERCENTUAL DE AUMENTO: 50%  |  SALÁRIO COM AUMENTO: R${newPaycheck}");
                Console.WriteLine("");
                break;

                case "2":
                newPaycheck = (double) ((oldPaycheck*0.35) + oldPaycheck);
                Console.WriteLine($"NOME: {name}  |  SALÁRIO: R${oldPaycheck}  |  CÓDIGO: {choice}  |  CARGO: Secretário  |  PERCENTUAL DE AUMENTO: 35%  |  SALÁRIO COM AUMENTO: R${newPaycheck}");
                Console.WriteLine("");
                break;

                case "3":
                newPaycheck = (double) ((oldPaycheck*0.2) + oldPaycheck);
                Console.WriteLine($"NOME: {name}  |  SALÁRIO: R${oldPaycheck}  |  CÓDIGO: {choice}  |  CARGO: Caixa  |  PERCENTUAL DE AUMENTO: 20%  |  SALÁRIO COM AUMENTO: R${newPaycheck}");
                Console.WriteLine("");
                break;

                case "4":
                newPaycheck = (double) ((oldPaycheck*0.1) + oldPaycheck);
                Console.WriteLine($"NOME: {name}  |  SALÁRIO: R${oldPaycheck}  |  CÓDIGO: {choice}  |  CARGO: Gerente  |  PERCENTUAL DE AUMENTO: 10%  |  SALÁRIO COM AUMENTO: R${newPaycheck}");
                Console.WriteLine("");
                break;

                case "5":
                newPaycheck = oldPaycheck;
                Console.WriteLine($"NOME: {name}  |  SALÁRIO: R${oldPaycheck}  |  CÓDIGO: {choice}  |  CARGO: Diretor  |  PERCENTUAL DE AUMENTO: 0%  |  SALÁRIO COM AUMENTO: R${newPaycheck}");
                Console.WriteLine("");
                break;
            }    
        }
    }
}
