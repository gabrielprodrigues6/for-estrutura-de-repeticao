public static class atividadematriz5
{
    public static void Executar()
    {
        double[,] notas = new double[3, 3];

        for (int linha = 0; linha < 3; linha++)
        {
            Console.WriteLine($"\nAluno {linha + 1}");

            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"Digite a nota{coluna + 1}: ");
                notas[linha, coluna] = double.Parse(Console.ReadLine()!);
            }
        }

        Console.WriteLine($"\nMédias dos alunos: ");

        for (int linha = 0; linha < 3; linha++)
        {
            double soma = 0;

            for (int coluna = 0; coluna < 3; coluna++)
            {
                soma += notas[linha, coluna];
            }
            double media = soma / 3;

            Console.WriteLine($"Aluno {linha + 1}: {media}");
        }
    }
}