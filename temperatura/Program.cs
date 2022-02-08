using System;

namespace temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a temperatura em graus Celsius");
            float temperaturaC = float.Parse(Console.ReadLine());

            float temperaturaF;
            temperaturaF = (float)(temperaturaC * 1.8) + 32;

            Console.WriteLine(temperaturaC + " graus Celsius corresponde a " + temperaturaF + " graus  Fahrenheit.");
            Console.ReadLine();
        }
    }
}