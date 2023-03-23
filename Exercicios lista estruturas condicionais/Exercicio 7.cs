int nascimento, idade;

Console.WriteLine("Digite o ano do seu nascimento");
nascimento = Convert.ToInt32(Console.ReadLine());
idade = 2023 - nascimento;
if (idade >= 18)
    Console.WriteLine("Você já pode votar e tirar habilitação.");
else if (idade >= 16 && idade < 18)
    Console.WriteLine("Você já pode votar.");
else
    Console.WriteLine("Você não pode votar nem tirar habilitação.");
