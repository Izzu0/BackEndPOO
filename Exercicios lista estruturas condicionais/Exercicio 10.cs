int codigo;

Console.WriteLine("Insira o codigo do produto");
codigo = Convert.ToInt32(Console.ReadLine());

switch (codigo)
{
    case 1:
        Console.WriteLine("Alimento não-perecível");
        break;
    case 2:
        Console.WriteLine("Alimento perecivel");
        break;

    case 3:
        Console.WriteLine("Alimento perecivel");
        break;

    case 4:
        Console.WriteLine("Alimento perecivel");
        break;

    case 5:
        Console.WriteLine("Vestuário");
        break;

    case 6:
        Console.WriteLine("Vestuário");
        break;

    case 7:
        Console.WriteLine("Higiene Pessoal");
        break;
    case 8:
        Console.WriteLine("Higiene Pessoal");
        break;
    case 9:
        Console.WriteLine("Higiene Pessoal");
        break;
    case 10:
        Console.WriteLine("Higiene Pessoal");
        break;

    case 11:
        Console.WriteLine("Higiene Pessoal");
        break;

    case 12:
        Console.WriteLine("Higiene Pessoal");
        break;

    case 13:
        Console.WriteLine("Higiene Pessoal");
        break;

    case 14:
        Console.WriteLine("Higiene Pessoal");
        break;

    case 15:
        Console.WriteLine("Higiene Pessoal");
        break;

    default:
        Console.WriteLine(" Código Inválido");
        break;
}
