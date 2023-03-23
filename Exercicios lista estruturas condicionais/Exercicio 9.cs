float SalarioprofA, SalarioprofB;
int HorasprofA, HorasprofB;

Console.WriteLine("Digite quantas horas o professor A trabalhou: ");
HorasprofA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o preço da hora do professor A: ");
SalarioprofA = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Digite quantas horas o professor B trabalhou: ");
HorasprofB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o preço da hora do professor B: ");
SalarioprofB = Convert.ToSingle(Console.ReadLine());


if ((HorasprofA * SalarioprofA) > (HorasprofB * SalarioprofB))
    Console.WriteLine("O salario do professor A é maior que do professor B");
else Console.WriteLine("O salario do professor B é maior que do professor A");
