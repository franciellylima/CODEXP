using System;

namespace Verificação_Par_ou_Impar_e_Menor_ou_Maior
{
    class Program
    {
        static void Main(string[] args){

            int n1;
            int n2;
            bool canConvert;
            Console.WriteLine("Digite um número inteiro");
            canConvert = int.TryParse(Console.ReadLine(), out n1); 

            if (!canConvert){
                Console.WriteLine("Você não digitou um número inteiro."); 
            }else{

                Console.WriteLine("Digite outro número inteiro");
                canConvert = int.TryParse(Console.ReadLine(), out n2);

                if (!canConvert){
                    Console.WriteLine("Você não digitou um número inteiro."); 
                }else{

                    if (n1 % 2 == 0 && n2 % 2 == 0){
                        Console.WriteLine($"({n1}) é par e ({n2}) é par.");

                    }else if (n1 % 2 == 0 && n2 % 2 != 0){
                        Console.WriteLine($"({n1}) é par e ({n2}) é impar.");

                    }else if (n1 % 2 != 0 && n2 % 2 == 0){
                        Console.WriteLine($"({n1}) é impar e ({n2}) é par.");

                    }else if (n1 % 2 != 0 && n2 % 2 != 0){
                        Console.WriteLine($"({n1}) é impar e ({n2}) é impar.");

                    }
                    
                    if (n1>n2){
                        Console.WriteLine($"({n1}) é o maior número e o ({n2}) é o menor número.");
                    }else if (n1<n2){
                        Console.WriteLine($"({n2}) é o maior número e o ({n1}) é o menor número.");
                    }else if (n1==n2){
                        Console.WriteLine($"({n1}) é o igual ao ({n2}).");
                    }
                }
            }
        }
    }
}
