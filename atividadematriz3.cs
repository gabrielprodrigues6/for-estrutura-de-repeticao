public static class atividadematriz3
{
    public static void Executar()
    {
        int[,] numero = new int[2, 2];
        int soma = 0;

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write($"Digite o número[{linha}, {coluna}]: ");
                numero[linha, coluna] = int.Parse(Console.ReadLine()!);

                soma += numero[linha, coluna];
            }
        }
        Console.WriteLine($"\nSoma total: {soma}");
    }
}