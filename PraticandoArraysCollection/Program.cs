
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

#region
//Console.WriteLine("Continue Praticando que você vai chegar lá");

//TestaArrayInt();
//void TestaArrayInt()
//{
//    int[] idades = new int[5];

//    idades[0] = 30;
//    idades[1] = 40;
//    idades[2] = 17;
//    idades[3] = 21;
//    idades[4] = 18;
//    Console.WriteLine($"Tamanho do Array =  {idades.Length}");

//    int acumulador = 0;

//    for (int i = 0; i < idades.Length; i++)
//    {
//        int idade = idades[i];
//        Console.WriteLine($"índice [{i}] = {idade}");
//        acumulador += idade;
//    }

//    int media = acumulador / idades.Length;
//    Console.WriteLine($"Média de idades = {media}");
//}


//TestaBuscaPalavra();
//void TestaBuscaPalavra()
//{
//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.Write($"Digite{i + 1}ª Palavra: ");
//        arrayDePalavras[i] = Console.ReadLine();
//    }

//    Console.Write("Digite palavra a ser encontrada: ");
//    var busca = Console.ReadLine();

//    foreach (string palavra in arrayDePalavras)
//    {
//        if (palavra.Equals(busca))
//        {
//            Console.Write($"Palavra encontrada = {busca}");
//            break;
//        }
//    }
//}


//Testantandobool();
//void Testantandobool()
//{
//    bool[] opcoes = { true, false, true, true, true, false };
//    for (int i = 0; i < opcoes.Length; i++)
//    {
//        Console.WriteLine($"Opcão {i}= {opcoes[i]}");
//    }

//}

//PesquisadorDePalavras();
//void PesquisadorDePalavras()
//{
//    List<string> buscador = new List<string>() { "Maça, Pera, Uva, Banana, Laranja" };

//    Console.WriteLine("Hortifruti online");
//    Console.WriteLine("O que quer pesquisar?");
//    string nomeFruta = Console.ReadLine();

//    if (nomeFruta.Contains(nomeFruta))
//    {
//        Console.WriteLine("Temos a Fruta desejada");
//    }
//    else
//    {
//        Console.WriteLine("Fruta em falta");
//    }
//}

//PesquisadorDePalavras1();
//void PesquisadorDePalavras1()
//{

//    Cria uma lista de frutas
//    List<string> frutas = new List<string>() {
//            "maçã", "banana", "laranja", "abacaxi", "uva"
//        };

//    Solicita ao usuário que digite o nome de uma fruta
//    Console.Write("Digite o nome de uma fruta: ");
//    string nomeFruta = Console.ReadLine();

//    Verifica se a fruta digitada está presente na lista
//    if (frutas.Contains(nomeFruta.ToLower()))
//    {
//        Console.WriteLine("Temos a fruta desejada!");
//    }
//    else
//    {
//        Console.WriteLine("Não temos essa fruta em estoque.");
//    }

//}


//buscandoElementoDoArray();
//void buscandoElementoDoArray()
//{
//    string[] listaPalavra = new string[5];

//    for (int i = 0; i < listaPalavra.Length; i++)
//    {
//        Console.WriteLine($"Digite{i + 1}ª palavra:");
//        listaPalavra[i] = Console.ReadLine();
//    }

//    Console.WriteLine("Digite palavra a ser encontrada:");
//    var busca = Console.ReadLine();

//    foreach (string palavra in listaPalavra)
//    {
//        if (palavra.Equals(busca))
//        {
//            Console.WriteLine($"Resultado da busca = {palavra}");
//        }
//        else
//        {
//            Console.WriteLine($"Palavra {busca} não encontrada");
//        }
//    }
//}

//diasDaSemana();
//void diasDaSemana()
//{
//    string[] diasDASemanas = new string[7];
//    diasDASemanas[0] = "domingo";
//    diasDASemanas[1] = "segunda";
//    diasDASemanas[2] = "terça";
//    diasDASemanas[3] = "quarta";
//    diasDASemanas[4] = "quinta";
//    diasDASemanas[5] = "sexta";
//    diasDASemanas[6] = "sabado";
//    Console.WriteLine($"a semana tem : {diasDASemanas.Length} dias");

//    for (int i = 0; i < diasDASemanas.Length; i++)
//    {
//        Console.WriteLine($"Os dias da semanas sao {i} = {diasDASemanas[i]}");
//    }
//}

//diasSemana();
//void diasSemana()
//{
//    string[] diaSemanas = new string[7]
//    {
//        "domingo", "segunda", "terça","quarta", "quinta", "sexta", "sabado"
//    };
//}

//Semanas();
void Semanas()
{
    string[] semana = new string[7] { "domingo", "segunda", "terça", "quarta", "quinta", "sexta", "sábado" };
    //for (int i = 0; i < semana.Length; i++)
    //{
    //    Console.WriteLine(semana[i]);
    //    Console.ReadLine();
    //}
    foreach (string diasSemanas in semana)
    {
        Console.WriteLine(diasSemanas);
        Console.ReadLine();
    }

}

//exemplo de array de duas dimensão
string[,] nomes = new string[2, 2]
{
    {"Pedro","Maria"},{"Manoér", "Juse"}
};

//ou atribuir o valor para o array indicando o índice da linha da coluna:

//Names();
void Names()
{
    string[,] name = new string[2, 2];
    name[0, 0] = "Pedro";
    name[0, 1] = "Maria";
    name[1, 0] = "Manoel";
    name[1, 1] = "Jose";

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.WriteLine("nomes [{0}, {1}] = {2}", i, j, name[i, j]);
        }
        Console.ReadLine();
    }
}
#endregion


//Array amostra = Array.CreateInstance(typeof(double), 5);
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);
////valores do array [5,9][1,8][7,1][10][6,9]
//TestMediana(amostra);
//void TestMediana(Array array)
//{
//    if ((array == null) || (array.Length == 0))
//    {
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
//    }
//    double[] numerosOrdenados = (double[])array.Clone();
//    Array.Sort(numerosOrdenados);
//    //[1,8][5,9][6,9][7,1][10] ordenação dos numeros

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;
//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
//    Console.WriteLine($"com base na amostra a mediana = {mediana}");
//}

//double[] Amostra = { 1, 4, 6, 8, 10 };

//BuscarMedia(Amostra);

//void BuscarMedia(Array array)
//{
//    if(array == null || array.Length == 0) 
//    {
//        Console.WriteLine("Não é possoivel mostra amostra nula ou vazia");
//        return;
//    }

//    double somatoria = 0;
//    foreach(double item in array)
//    {
//        somatoria += item;
//    }

//    double media = somatoria / Amostra.Length;
//    Console.WriteLine($"A soma dos valores é = {somatoria}");
//    Console.WriteLine($"A média de amostra é {media}");

//}


double MediaDaAmostra(double[] amostra)
{
    double media = 0;
    double acumulador = 0;

    if((amostra == null) || amostra.Length == 0)
    {
        Console.WriteLine("Amostra de dados nula ou vazia.");
        return 0;
    }
    else
    {
        for(int i = 0; i< amostra.Length; i++)
        {
            acumulador = acumulador + amostra[i];
        }

        media = acumulador / amostra.Length;
    }
    return media;
}

