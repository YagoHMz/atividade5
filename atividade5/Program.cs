using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Double[] Vet1 = new Double[5];
        Double[] Vet2 = new Double[5];

        Console.WriteLine("Digite os valores do Vetor 1: ");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(+(i + 1) + " Valor: ");
            Double.TryParse(Console.ReadLine(), out Vet1[i]);
        }

        Console.WriteLine("Digite os valores do Vetor 2: ");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(+(i + 1) + " Valor: ");
            Double.TryParse(Console.ReadLine(), out Vet2[i]);
        }

        char x;

        Console.WriteLine("a) A soma dos elementos de cada vetor, nas respectivas posições");
        Console.WriteLine("b) A diferença dos elementos de cada vetor, nas respectivas posições");
        Console.WriteLine("c)O produto dos elementos de cada vetor, nas respectivas posições");
        Console.WriteLine("d) A divisão entre os elementos de cada vetor, nas respectivas posições");

        Console.WriteLine("Digite sua opção: ");
        Char.TryParse(Console.ReadLine(), out x);

        if (x == 'a' || x == 'A')
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Soma da posição " + i + ": " + (Vet1[i] + Vet2[i]));
            }
        }

        else if (x == 'b' || x == 'B')
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Diferença da posição " + i + ": " + (Vet1[i] - Vet2[i]));
            }
        }

        else if (x == 'c' || x == 'C')
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Produto da posição " + i + ": " + (Vet1[i] * Vet2[i]));
            }
        }

        else if (x == 'd' || x == 'D')
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Divisão da posição " + i + ": " + (Vet1[i] / Vet2[i]));
            }
        }





    }
}