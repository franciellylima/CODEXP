using System;
using Aula_POO.Models;

namespace Aula_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno1 = new AlunoModel(); //instanciando o objeto AlunoModel //estou criando um  objeto aluno com as característica do meu aluno model

            Console.Clear();

            System.Console.WriteLine("Insira o nome do aluno"); //atralho cw
            aluno1.Nome = Console.ReadLine();

            System.Console.WriteLine("Insira o curso");
            aluno1.Curso = Console.ReadLine(); //atralho ct

            System.Console.WriteLine("Insira o RG");
            aluno1.Rg = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira a idade");
            aluno1.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine($@"
            Nome: {aluno1.Nome}
            Curso: {aluno1.Curso}
            Idade: {aluno1.Idade}
            Rg: {aluno1.Rg}
            ");
            


            
        }
    }
}
