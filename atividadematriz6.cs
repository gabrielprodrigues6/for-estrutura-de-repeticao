public static class atividadematriz6
{
    public static void Executar()
    {
        int[,] numero = new int[2, 3];
        int maior = int.MinValue;

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"Digite o número [{linha}, {coluna}]: ");
                numero[linha, coluna] = int.Parse(Console.ReadLine()!);

                if (numero[linha, coluna] > maior)
                {
                    maior = numero[linha, coluna];
                }
            }
        }
        Console.WriteLine($"\nMaior valor é o: {maior}");

    }
}