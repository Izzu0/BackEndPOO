float preco;
int pagamento;
Console.WriteLine("Insira o valor do produto: ");
preco = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Selecione a forma de pagamento: \n 1 - À vista em dinheiro \n 2 - À vista em cheque \n 3 - À vista no cartão de crédito \n 4 - Em duas vezes sem juros(apenas cartão da loja) \n 5 - Em duas vezes com juros(qualquer cartão)  ");
pagamento = Convert.ToInt32(Console.ReadLine());


switch (pagamento)
{
    case 1:
        Console.WriteLine("O valor a ser pago é de : " + (preco * 0.9));
        break;
    case 2: 
        Console.WriteLine("O valor a ser pago é de : " + (preco * 0.9));
        break;
    case 3:
        Console.WriteLine("O valor a ser pago é de : " + (preco * 0.85));
        break;
    case 4:
        Console.WriteLine("O valor a ser pago de cada parcela é de: "+ preco/2);
        break;
    case 5:
        Console.WriteLine("O valor a ser pago de cada parcela é de: " + ((preco*1.1)/2));
        break;

}