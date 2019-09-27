using System;

namespace AumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {

        string nFunc;
        float salario;
        double novoSalario;

        Console.WriteLine("Digite o nome do funcionário");
        nFunc = (Console.ReadLine());
        Console.WriteLine("Digite a quantidade de salário do funcionário");
        salario = float.Parse(Console.ReadLine());
        if (salario < 990){
            novoSalario = ((salario*(0.3))+salario);
            Console.WriteLine($"O salário do {nFunc} será aumentado para RS${novoSalario}");
        }else{
            Console.WriteLine($"O salário do {nFunc} não sofrerá alterações.");
            
        }


        }
    }
}
