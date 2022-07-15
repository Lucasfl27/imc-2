using System;

namespace Aula2IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso :");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("peso da pessoa" + peso);
            Console.WriteLine($"altura da pessoa: {altura}");

            float result = peso / (altura * altura);

            if (result < 18)
            {
                Console.WriteLine("Abaixo do peso");

            }
            else if (result > 18 && result > 25)
            {

                Console.WriteLine("normal");
            }
            else if (result > 25 && result > 29)
            {
                Console.WriteLine("Sobre peso");

            }
            else if (result > 29)
            {
                Console.WriteLine("Obesidade");
            }


        }
    }
}
