using System;

namespace Idade_das_pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int [10];
            int i = 1;
            int x = 0;
            int y = 0;
            do{
                Console.WriteLine("Digite sua idade");
                idade[i] = int.Parse(Console.ReadLine());

                if(idade[i]<18){
                    x++;
                }else{
                    y++;
                }
                i++;
            }while(i<=9);

            Console.WriteLine($"Existem {x} pessoas menores de idade e {y} pessoas maiores de idade.");
        }
    }
}
