using System;
using System.Collections.Generic; 

namespace CalculoIdade
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Informe sua data de aniversario (dia/mes/ano)"); 
            string userBornDate = Console.ReadLine();
            string[] dateSplited = userBornDate.Split('/'); 
            DateTime userBornDateDateTime = new DateTime(int.Parse(dateSplited[2]), int.Parse(dateSplited[1]), int.Parse(dateSplited[0])); 
            DateTime dateNow = DateTime.Now; 
            var differenceBetweenDates = dateNow.Subtract(userBornDateDateTime); 
            Console.WriteLine($"{differenceBetweenDates.Days} dias, {differenceBetweenDates.TotalHours} horas, {differenceBetweenDates.TotalMinutes} minutos"); 

        }

    } 
}
