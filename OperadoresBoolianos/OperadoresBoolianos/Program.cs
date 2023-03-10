


using System;
public class Exercicio1
{
    public static void Main()
    {
        int convidadosNoivo;
        int convidadosNoiva;
        int convidadosPresentesNoivo;
        int convidadosPresentesNoiva;
        

        convidadosNoivo = Convert.ToInt32(Console.ReadLine());
        convidadosNoiva = Convert.ToInt32(Console.ReadLine());
        convidadosPresentesNoivo = Convert.ToInt32(Console.ReadLine());
        convidadosPresentesNoiva = Convert.ToInt32(Console.ReadLine());

        bool convidados = convidadosNoivo > convidadosNoiva;
        bool convidadospenatras = (convidadosNoiva + convidadosNoivo) < (convidadosPresentesNoiva + convidadosPresentesNoivo);

        if (convidados == true)
        {
            Console.WriteLine("O noivo tem mais amigos que a noiva");

        }
        else if (convidados == false) {
            Console.WriteLine("A noiva ta tendo um caso");
        }

        if (convidadospenatras == true) {
            Console.WriteLine("tem penetras, chama a puliça");      
        }  

    }

};