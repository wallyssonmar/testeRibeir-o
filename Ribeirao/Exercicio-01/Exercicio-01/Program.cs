using System.Runtime.CompilerServices;

menuPrincipal();



void menuPrincipal() {
Console.Clear();
Console.WriteLine("Obrigado pela chance.");

Console.WriteLine("\npara ver as respostas das questões, escolha a opção:");
Console.WriteLine("1 - Questão 1");
Console.WriteLine("2 - Questão 2");
Console.WriteLine("3 - Questão 3");
Console.WriteLine("4 - Questão 4");
Console.WriteLine("5 - Questão 5");

int opcaoescolhida = int.Parse(Console.ReadLine());

switch (opcaoescolhida)
{
    case 1:
        questaoOne();
            break;
    case 2:
        questaoDois();
        break;
    case 3:
        questaoTres();
        break;
    case 4:
        questaoQuatro();
        break;
    case 5:
        questaoCinco();
        break;
}

 }
void questaoOne()
{
    //Questão 1
    Console.Clear();
    int indice = 13;
    int soma = 0;
    

    for (int k = 0; k < indice; k++)
    {

        soma += k;
    }

    Console.WriteLine($"O valor da soma é {soma}");
    voltarMenu();
}

void questaoDois()
{
    Console.Clear();
    Console.WriteLine("Digite um numero para a sequecia de Fibonacci");
    int n = int.Parse(Console.ReadLine());

    List<int> Lista = new List<int>();

    int a = 0, b = 1 , c;

    for(int i = 0; i < n; i++)
    {
        c = a + b;
        a = b;
        b = c;

        Lista.Add(c);
    }


    if(Lista.Contains(n))
    {
        Console.WriteLine($"O número {n} pertence a sequêcia");
    } else
    {
        Console.WriteLine($"O número {n} não pertence a sequêcia");
    }

    voltarMenu();


}
void questaoTres()
{
    Console.Clear ();
    Console.WriteLine("A) 1, 3, 5, 7, 9");
    Console.WriteLine("B) 2, 4, 8, 16, 32, 64, 128");
    Console.WriteLine("C) 0, 1, 4, 9, 16, 25, 36, 49");
    Console.WriteLine("D) 4, 16, 36, 64, 100");
    Console.WriteLine("E) 1, 1, 2, 3, 5, 8, 13");
    Console.WriteLine("F) 2, 10, 12, 16, 17, 18, 19, 200");
    voltarMenu();
}

void questaoQuatro()
{
    Console.Clear();
    Console.WriteLine("Primeiramente, eu iria numerar os 3 interruptores. Deixaria o primeiro interruptor ligado até uma lâmpada ficar quente e depois o desligaria. No segundo interruptor, eu deixaria ligado e o terceiro interruptor ficaria desligado. Quando fosse conferir as lâmpadas, desativaria o primeiro interruptor. A lâmpada que estiver quente e desligada é do primeiro interruptor, a que estiver acesa é do segundo interruptor e a que estiver desligada é do terceiro interruptor.");
    voltarMenu();
}

void questaoCinco()
{
    Console.Clear();
    Console.WriteLine("Escreva uma palavra");
    string palavra = Console.ReadLine();
    string palavraInvertida = inverterPalavra(palavra);
    Console.WriteLine($"A palavra normal : {palavra}");
    Console.WriteLine($"A palavra invertida : {palavraInvertida}");

    static string inverterPalavra(string palavra)
    {
        //transformo a string em char para poder acessar cada caractere e poder mexer com eles individualmente.
        char[] caracteres = palavra.ToCharArray();

        int comprimento = palavra.Length;

        string palavraInvertida = "";

        for (int i = comprimento - 1; i >= 0; i--)
        {
            palavraInvertida += caracteres[i];
        }
        return palavraInvertida;
    }
    voltarMenu ();
}

void voltarMenu()
{
    Console.WriteLine("Tecle alguma tecla para sair");
    Console.ReadKey();
    menuPrincipal();
}