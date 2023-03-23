using System.Linq.Expressions;

int A, B;
string operacao;

Console.WriteLine("Insira o valor do primeiro numero: ");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira o valor do segundo numero: ");
B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira a opção desejada: \n A - retornar o soma de dois números \n S - retornar a subtração de dois números \n M - retornar a multiplicação de dois números \n Q - retornar o quociente inteiro de uma divisão");
operacao = Console.ReadLine();


    switch (operacao)
    {
        case "A":
            Console.WriteLine("O valor da soma é : " + (A + B));
            break;
        case "a":
            Console.WriteLine("O valor da soma é : " + (A + B));
            break;
        case "S":
            Console.WriteLine("O valor da subtração é: " + (A - B));
            break;

        case "s":
            Console.WriteLine("O valor da subtração é: " + (A - B));
            break;
        case "M":
            Console.WriteLine("O valor da multiplicação é: " + (A * B));
            break;

        case "m":
            Console.WriteLine("O valor da multiplicação é: " + (A * B));
            break;

        case "Q":
            Console.WriteLine("O quociente da divisão é: " + (A / B));
            break;

        case "q":
            Console.WriteLine("O quociente da divisão é: " + (A / B));
            break;
    default:
        Console.WriteLine("Opção Inválida");
        break;

    }



