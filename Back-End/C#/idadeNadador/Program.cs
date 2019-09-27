using System;

namespace idadeNadador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Digite o nome do nadador");
            nome = Console.ReadLine();
            Console.WriteLine($"Qual é a idade do {nome}?");
            idade = int.Parse(Console.ReadLine());
            if (idade<=7){
                Console.WriteLine($"O {nome} faz parte da Categoria Infantil A");
            }else if (idade>=18){
                Console.WriteLine($"O {nome} faz parte da Categoria Adulto");
            }else if (idade<=10){
                Console.WriteLine($"O {nome} faz parte da Categoria Infantil B");
            }else if (idade<=13){
                Console.WriteLine($"O {nome} faz parte da Categoria Juvenil A");
            }else if (idade<=17){
                Console.WriteLine($"O {nome} faz parte da Categoria Juvenil B");
            }


        }
    }
}
