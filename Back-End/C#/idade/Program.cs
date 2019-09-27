using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu ano de nascimento");
            String userDateBorn = Console.ReadLine();
            String[] dateSplited = userDateBorn.Split("/");
            DateTime userDateBornDateTime = new DateTime (int.Parse(dateSplited[0]));
            DateTime dateNow = DateTime.Now;
            var differenceBetweenDates = dateNow.Subtract(userDateBornDateTime);
            Console.WriteLine($"{differenceBetweenDates.Days} dias");


        }
    }
}
