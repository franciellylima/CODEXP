using System;

namespace Notas_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aluno = new string [10];
            double[] nota1 = new double [10];
            double[] nota2 = new double [10];
            double[] media = new double [10];
            int aprovado = 0;
            int reprovado = 0;
            int i = 0;
            double mediaTotal = 0;

            

            do{
                Console.WriteLine("Digite o nome do aluno");
                aluno[i] = Console.ReadLine();
                Console.WriteLine($"Digite a 1° nota do {aluno[i]}");
                nota1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a 2° nota do {aluno[i]}");
                nota2[i] = double.Parse(Console.ReadLine());  
                media[i] = (nota1[i] + nota2[i])/2;
                if(media[i]>=7){
                    aprovado++;
                }else{
                    reprovado++;
                }
                i++;
            }while(i<10);
            i = 0;
            while(i<10){
                mediaTotal += media[i];
                i++;
            }
            Console.WriteLine($"A média da sala é: {mediaTotal/i}. Temos {aprovado} alunos aprovados e {reprovado} alunos reprovados.");
        }
    }
}
