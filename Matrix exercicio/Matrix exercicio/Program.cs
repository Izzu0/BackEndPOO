using System;

namespace Matrix_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ඞ");
            int a, b;
            Console.WriteLine("Insira o tamanho da linha da primeira matriz:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o tamanho da coluna da primeira matriz:");
            b = Convert.ToInt32(Console.ReadLine());

            int[,] matrixA = InputMatrizes(a,b);

            Console.WriteLine("Insira o tamanho da linha da segunda matriz:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o tamanho da coluna da segunda matriz:");
            b = Convert.ToInt32(Console.ReadLine());

            int[,] matrixB = InputMatrizes(a, b);


            Console.WriteLine("O resultado da soma das matrizes é:");
            SomarMatrizes(matrixA, matrixB);


        }

        public static int[,] InputMatrizes(int linhaEntrada, int colunaEntrada)
        {
            int[,] matrix = new int[linhaEntrada, colunaEntrada];
            int entrada;

            for (int l = 0; l < linhaEntrada; l++)
            {
                for (int c = 0; c < colunaEntrada; c++) 
                {
                    Console.WriteLine("Insira o valor da posição: " + l + "," + c);
                    entrada = Convert.ToInt32(Console.ReadLine());
                    matrix[l, c] = entrada;

                }
            
            }
            return matrix;
        
        }

        public static void OutputMatrizes(int[,] matrixOut)
        {
            for (int l = 0; l < matrixOut.GetLength(0); l++)
            {
                Console.WriteLine();
                Console.Write("|");
                for (int c = 0; c < matrixOut.GetLength(1); c++)
                {
                    
                    Console.Write(matrixOut[l, c]);
                    Console.Write("|");
                }
            
            }
        
        }


        public static void SomarMatrizes(int[,] matrixA, int[,] MatrixB)
        {
            if (matrixA.GetLength(0) == MatrixB.GetLength(0))

            {
                if (matrixA.GetLength(1) == MatrixB.GetLength(1))
                {
                    int[,] matrixR = new int[matrixA.GetLength(0), MatrixB.GetLength(1)];

                    for (int l = 0; l < matrixA.GetLength(0); l++)

                    {
                        for (int c = 0; c < matrixA.GetLength(1); c++)
                        {
                            matrixR[l, c] = matrixA[l, c] + MatrixB[l, c];

                        }
                            
                        


                    }

                    for (int l = 0; l < matrixR.GetLength(0); l++)
                    {
                        Console.WriteLine();
                        Console.Write("|");
                        for (int c = 0; c < matrixR.GetLength(1); c++)
                        {

                            Console.Write(matrixR[l, c]);
                            Console.Write("|");
                        }

                    }

                }

                else
                {
                    Console.WriteLine("Operação Invalida, matrizes de tamanhos diferentes");

                    
                }


            }
            else {
                Console.WriteLine("Operação Invalida, matrizes de tamanhos diferentes");
            }
        
        
                 
        }

    }
}
