using System;

namespace salário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário: ");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Seu salário ínicial: R$" + salario);

            float aumento;

            aumento = (float)((float)salario * 0.15);

            float salarioaumento;

            salarioaumento = salario + aumento;

            Console.WriteLine("Seu salário com aumento fica R$" + salarioaumento);


            float imposto;
            imposto = (float)((float)salarioaumento * 0.08);

            float salarioimposto = salarioaumento - imposto;

            Console.WriteLine("Seu salário final com 15% de aumento e 8% de desconto é R$" + salarioimposto);



            Console.ReadLine();
        }
    }
}
