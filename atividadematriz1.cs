using System.Xml;

public static class atividadematriz1
{
    public static void Executar()
    {
        string[,] nomes = new string[2, 2];

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write($"Digite o nome da posição[{linha}, {coluna}]: ");
                nomes[linha, coluna] = Console.ReadLine()!;
            }
        }
        Console.WriteLine();

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.WriteLine($"Linha {linha}, Coluna {coluna}: {nomes[linha, coluna]}");

            }
        }
    }
}