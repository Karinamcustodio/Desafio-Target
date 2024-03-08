<h1 align="center"> Desafio Target Sistemas</h1>

## 💻 Sobre

Neste repositório, você encontrará as resoluções para os desafios propostos. 
 - Todas as soluções foram implementadas em C# .NET 7.0.

## 📝 Resoluções

 - Primeiro Exercício
```bash
static void Exercicio1()
{
    int INDICE = 13;
    int SOMA = 0;
    int K = 0;

    while (K < INDICE)
    {
        K = K + 1;
        SOMA = SOMA + K;
    }

    Console.WriteLine(SOMA);
}
```

 - Segundo Exercício
```bash
static void Exercicio2()
{
    Console.WriteLine("Digite um número:");
    int numero = Convert.ToInt32(Console.ReadLine());

    int a = 0, b = 1, temp;
    bool pertence = false;

    while (b < numero)
    {
        temp = a;
        a = b;
        b = temp + b;

        if (b == numero)
        {
            pertence = true;
            break;
        }
    }

    if (pertence)
    {
        Console.WriteLine($"{numero} pertence à sequencia Fibonacci.");
    } else
    {
        Console.WriteLine($"{numero} não pertence à sequencia Fibonacci.");
    }
}
```

 - Quinto Exercício
```bash
static void Exercicio5()
{
    Console.WriteLine("Digite uma palavra:");
    string palavra = Console.ReadLine();
    string palavraInvertida = "";

    for (int i = palavra.Length - 1; i >= 0; i--)
    {
        palavraInvertida += palavra[i];
    }
            
    Console.WriteLine($"A palavra invertida fica: {palavraInvertida}");
}
```

Feito por Karina Moreira Custódio 👋🏽 [Entre em contato!](https://www.linkedin.com/in/karina-moreira-custodio)
