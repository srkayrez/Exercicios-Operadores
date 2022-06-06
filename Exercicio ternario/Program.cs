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
            Console.WriteLine($"Digite a {i + 1} nota: ");
            notas[i] = int.Parse(Console.ReadLine());

            notaFinal += notas[i];

        }

        media = notaFinal / qtdNotas;

        var situacao = (media >= 7 ) ? "aprovado" : "reprovado";
       
        Console.WriteLine(situacao);
    }
}