using System;

namespace areaTerreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a medida do primeiro lado do terreno: ");
            float primeirolado = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida do segundo lado do terreno: ");
            float segundolado = float.Parse(Console.ReadLine());



            float area;
            area = primeirolado * segundolado;
            Console.WriteLine("A área do terreno é: " + area);

            Console.ReadLine();

        }
    }
}