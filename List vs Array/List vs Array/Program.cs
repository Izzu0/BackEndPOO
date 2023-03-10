string[] convidados = new string[5];
int i = 0;
int a = 0;

do
{
    Console.WriteLine("Insira o nome do convidado: ");
    convidados[i] = Convert.ToString(Console.ReadLine());

    i++;
}while (i < convidados.Length);

Console.WriteLine("Lista de convidados: ");
do
{
    Console.WriteLine(convidados[a]);

    a++;
} while (a < convidados.Length);


