using System;

namespace padaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de pães vendidos: ");
            float quantpaes = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de broas vendidos: ");
            float quantbroas = float.Parse(Console.ReadLine());

            float totalganho;
           
            totalganho = (float)((quantpaes * 0.12) + (quantbroas * 1.50));

            Console.WriteLine("O lucro foi de r$: " + totalganho);

            float poupanca;
            poupanca = (float)((totalganho * 0.10));

            Console.WriteLine("O dono deve juntar R$" + poupanca + " em sua conta.");
            
            Console.ReadLine();



        }
    }
}
