using System;

namespace Aula20._03
{
    class Program
    {
        static void Main(string[] args)
            
        {
            float a, b, c;
            Console.WriteLine("Insira o valor do lado A do triangulo");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Insira o valor do lado B do triangulo");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Insira o valor do lado C do triangulo");
            c = Convert.ToSingle(Console.ReadLine());

            if ((a + b < c) || (a + c < b) || (b + c < a))
            {
                Console.WriteLine("Não é um triangulo");

            }
            else
            {

                if ((a == b))
                {
                    if ((a == c))
                    {
                        Console.WriteLine("Equilátero.");
                    }
                    else
                    {
                        Console.WriteLine("Isósceles.");
                    }
                }
                else if (a == c)
                {

                    Console.WriteLine("Isósceles.");

                }
                else if (b == c)
                {
                    Console.WriteLine("Isósceles.");
                }

                else
                {
                    Console.WriteLine("Escaleno.");
                }
            }
        }
    }
}
