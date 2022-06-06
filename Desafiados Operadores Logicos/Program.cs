using System;
class Program
{
    static void Main(string[] args)
    {
        int qtdNotas;
        double notaFinal = 0, media;
        Console.WriteLine("Digite quantas notas o aulo teve: ");
        qtdNotas = int.Parse(Console.ReadLine());

        double[] notas = new double[qtdNotas];

        for (int i = 0; i < qtdNotas; i++)
        {
            Console.WriteLine($"Digite a {i+1} nota: ");
            notas[i] = int.Parse(Console.ReadLine());

            notaFinal += notas[i];
        }
        
        media = notaFinal / qtdNotas;

        if (media >= 7)
        {
            Console.WriteLine($"Aluno aprovado com {media}");
        }
        else if (media <= 5)
        {
            Console.WriteLine($"Aluno reprovado com {media}");
        }
        else if (media >= 5 && media <= 7)
        {
            Console.WriteLine($"Alno em recuperação com {media}");
        }
    }
}