using System;

namespace Rodizio_Veicular
{
    class Program
    {
        static void Main(string[] args)
        {
            int placa;
            Console.WriteLine("Rodizio Veicular");
            Console.WriteLine("Insira o último digito de sua placa");
            placa = int.Parse(Console.ReadLine());

            if(placa == 0 || placa ==1){
                Console.WriteLine("O rodizio do seu veículo é de Segunda-Feira");
            }else if(placa == 2 || placa == 3){
                Console.WriteLine("O rodizio do seu veículo é de Terça-Feira");
            }else if(placa == 4 || placa == 5){
                Console.WriteLine("O rodizio do seu veículo é de Quarta-Feira");
            }else if(placa == 6 || placa == 7){
                Console.WriteLine("O rodizio do seu veículo é de Quinta-Feira");
            }else if(placa == 8 || placa == 9){
                Console.WriteLine("O rodizio do seu veículo é de Sexta-Feira");
            }else{
                Console.WriteLine("Insira apenas o último digito");
            }


        }
    }
}
