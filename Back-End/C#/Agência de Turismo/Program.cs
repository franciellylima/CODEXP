using System;

namespace Agência_de_Turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string decision;
            string [] name = new string[i];
            string [] origin = new string[i];
            string [] whither = new string[i];//destino
            DateTime [] dateFly = new DateTime[i];
            int choice;


            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
            Console.WriteLine("(1) Cadastrar passagem");
            Console.WriteLine("");
            Console.WriteLine("(2) Listar Passagens");
            Console.WriteLine("");
            Console.WriteLine("(3) Sair");
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
            choice = int.Parse(Console.ReadLine());

            switch(choice){
                
                
                case (1):
                    Console.WriteLine("Cadastro de passagem");

                    do{
                    Console.WriteLine("Digite seu nome completo");
                    name[i] = Console.ReadLine();
                    Console.WriteLine("Digite sua origem");
                    origin[i] = Console.ReadLine();
                    Console.WriteLine("Digite seu destino");
                    whither[i] = Console.ReadLine();
                    Console.WriteLine("Digite a data do seu Vôo");
                    dateFly[i] = DateTime.Parse(Console.ReadLine());
                    i++;
                    Console.WriteLine("Você deseja realizar um novo cadastro? S/N");
                    decision = Console.ReadLine();
                    
                    }while(decision == "S");
                    break;

                case (2): 

                break;

                case (3):
                    Console.WriteLine("Obrigado por nos visitarmos.");
                break;
            }
            
        }
    }
}
