namespace DesafioTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Console.WriteLine();
            Exercicio2();
            Console.WriteLine();
            Exercicio5();

            Console.ReadKey();
        }

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
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequencia Fibonacci.");
            }
        }

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
    }
}