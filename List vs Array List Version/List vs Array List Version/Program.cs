List<string> convidados = new List<string>();




do
{
    Console.WriteLine("Digite o nome do convidado ou digite SAIR para parar:  ");
    convidados.Add(Convert.ToString(Console.ReadLine()));

    if (convidados.Contains("SAIR")){

        break;
    }

} while(true);

Console.WriteLine("A lista possui: " +convidados.Count() +" convidados");

