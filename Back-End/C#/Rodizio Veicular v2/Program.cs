using System;

namespace Rodizio_Veicular_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            int quantCaracteres;
            int final;
            Console.WriteLine("Rodizio Veicular");
            Console.WriteLine("Insira a placa do seu veículo");
            placa = Console.ReadLine();
            quantCaracteres = placa.Length; //.Length conta a quantidade de caracteres
            // final = placa.Substring(5); //.Substring(i) remove a quantidade de caracteres que você setar 
            final = int.Parse(placa.Substring(quantCaracteres - 1)); //.String(quantCaracteres - i) mostra a quantidade de caracteres que você setou a partir do último 
            if(final == 0 || final ==1){
                Console.WriteLine("O rodizio do seu veículo é de Segunda-Feira");
            }else if(final == 2 || final == 3){
                Console.WriteLine("O rodizio do seu veículo é de Terça-Feira");
            }else if(final == 4 || final == 5){
                Console.WriteLine("O rodizio do seu veículo é de Quarta-Feira");
            }else if(final == 6 || final == 7){
                Console.WriteLine("O rodizio do seu veículo é de Quinta-Feira");
            }else if(final == 8 || final == 9){
                Console.WriteLine("O rodizio do seu veículo é de Sexta-Feira");
            }else{
                Console.WriteLine("Insira apenas o último digito");
            }
           


        }
    }
}
