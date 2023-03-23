using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            Console.WriteLine("Digite um número: ");
            numero = Convert.ToSingle(Console.ReadLine());

            if (numero >= 1 && numero <= 9)
            {
                Console.WriteLine("O valor está na faixa permitida.");
            } 
            else
            {
                Console.WriteLine("O valor está fora da faixa permitida.");
            }


        }
    }
}
