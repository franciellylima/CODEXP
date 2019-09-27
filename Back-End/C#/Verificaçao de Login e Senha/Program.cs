using System;

namespace LoginSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Modelo--");
            string senha, nome;
            
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            if(nome.Length <= 1){
                Console.WriteLine("Digite seu nome corretamente");
                nome = Console.ReadLine();    
            }
            // Console.WriteLine("Digite seu nome");
            // nome = Console.ReadLine();
            // do{ 
            //     Console.WriteLine("O campo nome precisa ter mais de 2 caracteres, digite ele novamente");
            //     nome = Console.ReadLine();
            // }while (nome.Length <= 1);  //DoWhile verifica a condição depois


            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();
            do{
                // if(senha.Length < 6){
                    Console.WriteLine("O campo senha precisa ter mais de 6 caracteres, digite ele novamente");
                    senha = Console.ReadLine();
                // }
                
            }while (senha.Length < 6);      
        }   
    }
}
