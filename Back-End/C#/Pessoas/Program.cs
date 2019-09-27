using System;

namespace Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            int[] idade = new int[10];
            double[] peso = new double[10];
            double[] altura = new double[10];
            string[] sexo = new string[10];
            string [] masculino = new string[10];
            string [] feminino = new string[10];
            int choice , opcao;
            string awnser;
            int i = 0;

            do{
            
            i = 0;
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("");
            Console.WriteLine("(1) Cadastro de usuário");
            Console.WriteLine("(2) Total de Homens");
            Console.WriteLine("(3) Total de Mulheres");
            Console.WriteLine("(4) Média de idade dos Homens");
            Console.WriteLine("(5) Média de idade das Mulheres");
            Console.WriteLine("(6) Média de idade das Mulheres.");
            Console.WriteLine("(7) Nome e IMC dos Homens e das Mulheres");
            Console.WriteLine("(0) Sair");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
            choice = int.Parse(Console.ReadLine());

            switch(choice){

                case 1:

                    Console.WriteLine("");
                    Console.WriteLine("Cadastro de usuário:");
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Informe seu nome:");
                    nome[i] = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Informe sua idade:");
                    idade[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Informe seu peso");
                    peso[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Informe sua altura");
                    altura[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    // Console.WriteLine("Informe seu sexo");
                    // Console.WriteLine("");
                    // Console.WriteLine("(1) Masculino");
                    // Console.WriteLine("(2) Feminimo");
                    // sexo[i] = int.Parse(Console.ReadLine());
                    
                    // switch(sexo){

                    //     case 1:
                    //     masculino[i] = Console.ReadLine();
                    //     break;

                    //     case 2:
                    //     feminino[i] = Console.ReadLine();
                    //     break;
                    // }
                    
                    i++;

                    Console.WriteLine("Deseja cadastrar um novo usuário? S/N");
                    Console.WriteLine("");
                    awnser = Console.ReadLine();
                    Console.WriteLine("");
                    while(awnser == "s" || awnser == "S"){
                        Console.WriteLine("");
                        Console.WriteLine("Informe seu nome:");
                        nome[i] = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Informe sua idade:");
                        idade[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Informe seu peso");
                        peso[i] = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Informe sua altura");
                        altura[i] = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        do{
                        Console.WriteLine("Informe seu sexo");
                        Console.WriteLine("");
                        Console.WriteLine("(1) Masculino");
                        Console.WriteLine("(2) Feminimo");
                        opcao = int.Parse(Console.ReadLine());
                         switch(opcao){

                            case 1:
                            sexo[i] = "Masculino";
                            break;

                            case 2:
                            sexo[i] = "Feminino";
                            break;
                            default:

                            Console.WriteLine("VAlor inválido");
                            break;
                        }
                         
                       } while (opcao != 1 || opcao != 2);
                       
                       
                        
                        i++;

                        Console.WriteLine("Deseja cadastrar um novo usuário? S/N");
                        Console.WriteLine("");
                        awnser = Console.ReadLine();
                        Console.WriteLine("");


                    }
                  
                break;


                case 2:
                    // foreach (var item in )
                    // Console.WriteLine($"O")
                break;

                case 3:
                break;

                case 4:
                break;

                case 5:
                break;

                case 6:
                break;

                case 7:
                break;

                case 0:

                    Console.WriteLine("Obrigado por utilizar nosso sistema. Até logo! <3");
                    Console.WriteLine("");
                break;

            }

            }while(choice != 0);

            




        }
    }
}
