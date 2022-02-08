using System;

namespace diasdevida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade? ");
            float idade = float.Parse(Console.ReadLine());


            float diasvida;

            diasvida = idade * 365;

            Console.WriteLine(nome + " possui " + diasvida + " dias de vida.");
            Console.ReadLine();


        }
    }
}
