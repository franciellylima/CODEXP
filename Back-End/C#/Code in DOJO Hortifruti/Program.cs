using System;

namespace Code_in_DOJO_Hortifruti
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produto = new string[10];
            float[] preco = new float[10];
            float precoTotal = 0;
            int i = 0;
            string awnser;
            int choice;


            do{
            i = 0;
            Console.WriteLine("");
            Console.WriteLine("-----------------------Hortifruti------------------------");
            Console.WriteLine("");
            Console.WriteLine("(1) Cadastrar um produto");
            Console.WriteLine("(2) Listar todos os produtos");
            Console.WriteLine("(3) Calcular a soma de todos os preços dos produtos");
            Console.WriteLine("(0) Sair");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("");


            choice = int.Parse(Console.ReadLine());

            switch(choice){

                case 1:

                    Console.WriteLine("");
                    Console.WriteLine("Digite o nome do produto que deseja cadastrar.");
                    produto[i] = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Informe o valor do produto:");
                    preco[i] = float.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Deseja cadastrar um novo produto? S/N");
                    awnser = Console.ReadLine();
                    Console.WriteLine("");
                    i++;
                    while(awnser == "S" || awnser == "s"){
                        if(i<=9){
                        Console.WriteLine("Digite o nome do produto que deseja cadastrar.");
                        produto[i] = Console.ReadLine(); 
                        Console.WriteLine("");
                        Console.WriteLine("Informe o valor do produto:");
                        preco[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Deseja cadastrar um novo produto? S/N");
                        awnser = Console.ReadLine();
                        Console.WriteLine("");
                        i++;
                        }else{
                            Console.WriteLine("Você já cadastrou a quantidade máxima permitida de produtos");
                            Console.WriteLine("");            
                            break;
                        }
                    }
                
                break;

                case 2:

                    Console.WriteLine("");
                    Console.WriteLine("Lista de todos os produtos:");
                    Console.WriteLine("");           
                    i = 0;
                    while(i<=9){
                        if(produto[i] != null){
                            Console.WriteLine($"Nome: {produto[i]} - Preço: R${preco[i]}");
                            i++;
                        }
                            i++;
                    }

                break;

                case 3:

                    Console.WriteLine("");
                    i=0;
                    while(i<=9){
                    precoTotal = precoTotal + preco[i];
                    i++;
                    }
                      if(precoTotal != 0){
                            Console.WriteLine($"A soma total dos preços dos produtos é: R${precoTotal}");
                            i++;
                        }else{
                            Console.WriteLine("Você não possui itens na sua lista de produtos para serem somados.");
                            Console.Write("");
                            break;
                        }

                break;

                case 0:

                    Console.WriteLine("");
                    Console.WriteLine("Obrigada por utilizar nosso sistema de cadastro! <3 :)");
                    Console.WriteLine("");

                break;

                default: 

                    Console.WriteLine("");
                    Console.WriteLine("Por favor escolha uma das opçãos mencionadas!");
                    Console.WriteLine("");

                break;
            }

            }while(choice!=0);

        }
    }
}


//https://pt.stackoverflow.com/questions/3925/manter-zero-ap%C3%B3s-a-v%C3%ADrgula-usando-o-tipo-float