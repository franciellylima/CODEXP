using System;

namespace Escadinha
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            // string text;
            string[] space = new string[i];

            // Console.WriteLine("Digite uma palavra");
            // text = Console.ReadLine();

            while(i<=10){

                space[i+1] = "x";
                // Console.WriteLine($"{space[i]}{text}");
                Console.WriteLine(space[i]);
                i++;

            }
        }
    }
}
