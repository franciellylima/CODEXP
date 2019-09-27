using System;

namespace Cadastro_de_Produtos_com_For
{
    class Program
    {
        static void Main(string[] args){
            string[] produtoNome = new string[3];
            double[] produtoPreco = new double[3];

            for(int i =0; i <3; i++){
                Console.WriteLine($"Digite o nome do {i+1}° produto");
                produtoNome[i] = Console.ReadLine();
                Console.WriteLine("Digite o Preço");
                produtoPreco[i] = double.Parse(Console.ReadLine());       
            }

            foreach (var item in produtoNome){
                Console.WriteLine($"Produto: {item}");
            }  
        }
    }
}
