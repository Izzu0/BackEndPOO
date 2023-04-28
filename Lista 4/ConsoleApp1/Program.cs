using System;
using System.Security.Cryptography;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> array = new List<int>();
            exec3(array);
            Console.ReadKey();

        }
        public static void ImprimirEntradas(List<int> arrayNumeros)
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um número inteiro:");
                lista.Add(Convert.ToInt32(Console.ReadLine()));
            }
            
            foreach (int batatinha in lista)
            {
                Console.WriteLine(batatinha);
            }
                    //Nome da Variavel        na Colecao de Dados  
            //foreach(var xxxxxxxxxxxxxxxxxxxxx in collectionY)            
        }
        public static void listaAlunos(List<int> arrayNumeros)
        {
            List<int> alunos = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insira o número da matrícula:");
                alunos.Add(Convert.ToInt32(Console.ReadLine()));
                
            }


            foreach (int batatinha in alunos)
            {
                Console.WriteLine(batatinha);
            }
            //Nome da Variavel        na Colecao de Dados  
            //foreach(var xxxxxxxxxxxxxxxxxxxxx in collectionY)            
        }
        static int exec3(List<int> listNum, string msg = "Insira um Número: ")
        {


            int entrada;
            int i;
            for (i = 0; i < 999; i++)
            {
                Console.WriteLine(msg);
                listNum.Add(Convert.ToInt32(Console.ReadLine()));
                if (entrada == 999)
                    break;
                listNum[i] = entrada;

            }
            return i;
        }

    }
}