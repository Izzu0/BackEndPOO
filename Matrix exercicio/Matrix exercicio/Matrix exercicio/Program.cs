using System;

namespace Matrix_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcoes;
            Console.WriteLine("1 2 ou 3 :");
            opcoes = Convert.ToInt32(Console.ReadLine());
            

            

            switch (opcoes)
            {

                case 1:
                    int a1, b1;
                    Console.WriteLine("Insira o tamanho da linha da primeira matriz:");
                    a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira o tamanho da coluna da primeira matriz:");
                    b1 = Convert.ToInt32(Console.ReadLine());

                    int[,] matrixA1 = InputMatrizes(a1, b1);

                    Console.WriteLine("Insira o tamanho da linha da segunda matriz:");
                    a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira o tamanho da coluna da segunda matriz:");
                    b1 = Convert.ToInt32(Console.ReadLine());

                    int[,] matrixB1 = InputMatrizes(a1, b1);


                    Console.WriteLine("O resultado da soma das matrizes é:");
                    SomarMatrizes(matrixA1, matrixB1);
                    break;

                    

                case 2:
                    
                int a2, b2;
                Console.WriteLine("Insira o tamanho da linha da primeira matriz:");
                a2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o tamanho da coluna da primeira matriz:");
                b2 = Convert.ToInt32(Console.ReadLine());

                int[,] matrixA2 = InputMatrizes(a2, b2);

                Console.WriteLine("Insira o tamanho da linha da segunda matriz:");
                a2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o tamanho da coluna da segunda matriz:");
                b2 = Convert.ToInt32(Console.ReadLine());

                int[,] matrixB2 = InputMatrizes(a2, b2);


                Console.WriteLine("O resultado da multiplicação das matrizes é:");
                MultiplicarMatrizes(matrixA2, matrixB2);
                break;


                case 3:

                    int a3, b3;
                    Console.WriteLine("Insira o tamanho da linha da matriz:");
                    a3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira o tamanho da coluna da matriz:");
                    b3 = Convert.ToInt32(Console.ReadLine());
                    diagonalMatriz(InputMatrizes(a3, b3));

                    break;



                case 4:
                    string[,] matrixVizinhos = new string[10, 10];
                    int entradaColuna, entradaLinha;
                    for (int l = 0; l < 10; l++)
                    {
                        for (int c = 0; c < 1; c++)
                        {
                            Console.WriteLine("Insira a linha do " + (l+1) + "º número: ");
                            entradaLinha = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Insira a coluna do " + (l+1) + "º número: ");
                            entradaColuna = Convert.ToInt32(Console.ReadLine());
                            matrixVizinhos[entradaLinha, entradaColuna] = "X";
                        }
                    }
                    for (int l = 0; l < matrixVizinhos.GetLength(0); l++)
                    {
                        Console.WriteLine();
                        Console.Write(" | ");
                        for (int c = 0; c < matrixVizinhos.GetLength(1); c++)
                        {
                            if (matrixVizinhos[c, l] == "X")
                            {
                                matrixVizinhos[c - 1, l - 1] = "1";
                                matrixVizinhos[c - 1, l + 1] = "1";
                                matrixVizinhos[c + 1, l - 1] = "1";
                                matrixVizinhos[c + 1, l + 1] = "1";
                                matrixVizinhos[c , l - 1] = "1";
                                matrixVizinhos[c , l + 1] = "1";
                                matrixVizinhos[c - 1, l] = "1";
                                matrixVizinhos[c + 1, l] = "1";
                                Console.Write(matrixVizinhos[l, c]);
                                Console.Write(" | ");
                            }
                            else
                            {

                                Console.Write(matrixVizinhos[l, c]);
                                Console.Write(" | ");
                            }   
                        }


                    }

                    break;

            }
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
        public static void diagonalMatriz(int [,] matrixDiag)
        {
            for (int l = matrixDiag.GetLength(0); l >= 0; l--)
            {
                Console.WriteLine();
                for (int c = matrixDiag.GetLength(1); c >= 0; c--)
                {

                    if (l == c) {
                        Console.Write("|");
                        Console.Write(matrixDiag[l, c]);
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

            }
        }
        public static void MultiplicarMatrizes(int[,] matrixA, int[,] MatrixB)
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
                            matrixR[l, c] = matrixA[l, c] * MatrixB[l, c];

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
            else
            {
                Console.WriteLine("Operação Invalida, matrizes de tamanhos diferentes");
            }



        }

    }
}
