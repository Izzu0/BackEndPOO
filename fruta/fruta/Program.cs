using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        string entrada = "banana, maçã, abacaxi, banana, uva, uva, laranja";

        string[] frutas = entrada.Split(',');

        List<string> frutasUnicas = new List<string>();

        foreach (string fruta in frutas)
        {
            string frutaFormatada = fruta.Trim().ToLower();

            if (!frutasUnicas.Contains(frutaFormatada))
            {
                frutasUnicas.Add(frutaFormatada);

                string frutaPrimeiraMaiuscula = char.ToUpper(frutaFormatada[0]) + frutaFormatada.Substring(1);

                frutasUnicas.Add(frutaPrimeiraMaiuscula);
            }
        }

        Console.WriteLine("Frutas formatadas:");
        foreach (string frutaFormatada in frutasUnicas)
        {
            Console.WriteLine(frutaFormatada);
        }
    }
}