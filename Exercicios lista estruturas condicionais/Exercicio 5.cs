float A, B, C;
Boolean maior;

Console.WriteLine("Insira o valor de A: ");
A = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Insira o valor de B: ");
B = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Insira o valor de C: ");
C = Convert.ToSingle(Console.ReadLine());

if (A + B > C)
    maior = true; 
else 
    maior = false;
if (maior == true)
    Console.WriteLine("O valor da soma de A e B é maior que o valor de C");
if(maior == false)
    Console.WriteLine("O valor da soma de A e B é menor que o valor de C");
