using System;

namespace Lista_de_Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=0;
            string[] item = new string[6];
            Console.WriteLine("LISTA DE COMPRAS");

            while(cont<=5){
                Console.WriteLine("Digite um item da lista de compras");
                item[cont] = Console.ReadLine();
                cont++;
            }
            cont=0;
            while(cont<=5){
                Console.WriteLine($"O {cont+1}° item da lista é {item[cont]}");
                cont++;
            }
        }
    }
}
