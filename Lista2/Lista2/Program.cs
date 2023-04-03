// See https://aka.ms/new-console-template for more information
int exercicio;

do
{
    Console.WriteLine("Selecione o exercicio desejado: 8, 9, 10, 11, 12, 13, 14, 15 ou 0 para sair");
    exercicio = Convert.ToInt32(Console.ReadLine());





    switch (exercicio)
    {




        case 8:
            string exerc8Nome;
            Console.Write("Insira seu nome: ");
            exerc8Nome = Console.ReadLine();
            Console.WriteLine("Seu Nome invertido: ");
            Console.WriteLine(exerc8Nome.Reverse().ToArray());


            break;
        case 9:
            int exerc9Numero = 1;

            while (exerc9Numero <= 99)
            {
                Console.WriteLine(exerc9Numero);
                exerc9Numero += 2;
            }
            break;


        case 10:
            int exerc10Alunos, exerc10Contador = 1;
            float exerc10Notas = 0, exerc10Media = 0;


            Console.WriteLine("Insira a quantia de alunos da sala: ");
            exerc10Alunos = Convert.ToInt32(Console.ReadLine());
            while (exerc10Contador <= exerc10Alunos)
            {

                Console.WriteLine("Insira a nota do aluno: ");
                exerc10Notas = Convert.ToSingle(Console.ReadLine());
                exerc10Media += exerc10Notas;
                exerc10Contador++;
            }
            Console.WriteLine("A média aritimetica da sala é: " + (exerc10Media / exerc10Alunos));


            break;


        case 11:
            int exerc11contador = 0;
            int[] exerc11numeros = new int[10];
            while (exerc11contador <= 9)
            {
                Console.WriteLine("Insira um número: ");
                exerc11numeros[exerc11contador] = Convert.ToInt32(Console.ReadLine());
                exerc11contador++;

            }
            Console.WriteLine("O maior número da lista é: " + exerc11numeros.Max());

            break;

        case 12:
            int iwhile = 1, idowhile = 1;
            for (int i = 1; i <= 100; i++)
            { Console.WriteLine(i); }

            while (iwhile <= 100)
            {
                Console.WriteLine(iwhile);
                iwhile++;
            }
            do
            {
                Console.WriteLine(idowhile);
                idowhile++;
            } while (idowhile <= 100);


            break;

        case 14:
            double exer14velocidade, exerc14opcao;
            Console.WriteLine("insira um valor para conversão: ");
            exer14velocidade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Selecione 1 para converter de km/h para m/s ou 2 para converter de m/s para km/h");
            exerc14opcao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(exercicio14(exer14velocidade, exerc14opcao));


            break;
        case 13:
            double exerc13numero, exerc13quadrado, exerc13cubo, exerc13raiz;
            do
            {
                Console.WriteLine("Insira um número para receber seus quadrado, cubo e raiz: ");
                exerc13numero = Convert.ToDouble(Console.ReadLine());

                exerc13quadrado = exerc13numero * exerc13numero;
                exerc13cubo = exerc13numero * exerc13numero * exerc13numero;
                exerc13raiz = Math.Sqrt(exerc13numero);
                Console.WriteLine("O quadrado de: " + exerc13numero + " é: " + exerc13quadrado);
                Console.WriteLine("O cubo de: " + exerc13numero + " é: " + exerc13cubo);
                Console.WriteLine("A raiz de: " + exerc13numero + " é: " + exerc13raiz);
            } while (exerc13numero > 0);

            break;

        case 15:
            Console.WriteLine(exercicio15());

            break;

        default:
            break;
    }
} while (exercicio != 0);



static double exercicio14(double velocidadeOriginal,double opcao14) {
   
    

    switch (opcao14) {

        case 1:
            return velocidadeOriginal / 3.6; //convert km/h para m/s
        case 2:
            return velocidadeOriginal * 3.6; //convert m/s para km/h 
        default:
            return 0;
    
    }
        
    


   


}


     

static double exercicio15()
    {
        double salario = 2000, aumento = 0.015;
        int ano = 2006;


        while (ano <= 2023)
        {
            salario += salario * aumento;
            ano++;
            aumento *= 2;

        }
        return salario;
    }
