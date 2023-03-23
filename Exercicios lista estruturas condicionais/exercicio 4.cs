using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, pesoideal;
            string sexo;
            Console.WriteLine("Digite sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu sexo: (M para masculino ou F para feminino)");
            sexo = Console.ReadLine();

            if (sexo == "M" || sexo == "m")
            {
                pesoideal = (72.7 * altura) - 58;
                Console.WriteLine("Seu peso ideal é: " + pesoideal);
            }
            else if (sexo == "F" || sexo == "f")
            {
                pesoideal = (62.1 * altura) - 44.7;
                Console.WriteLine("Seu peso ideal é: " + pesoideal);
            }

        }
    }
}
