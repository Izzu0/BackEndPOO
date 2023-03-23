using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sexo;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sexo: (F para Feminino ou M para Masculino)");
            sexo = Console.ReadLine();

            if (sexo == "F" || sexo == "f")
            {
                Console.WriteLine(nome + "  Sra.");
            }
            else if (sexo == "M" || sexo == "m")
            {
                Console.WriteLine(nome + " Sr.");
            }
        }
    }
}
