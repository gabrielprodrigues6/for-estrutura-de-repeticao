public static class atividadematriz2
{
    public static void Executar()
    {
        int[,] numero = new int[2, 3];

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"Digite o número da posição[{linha}, {coluna}]: ");
                numero[linha, coluna] = int.Parse(Console.ReadLine()!);
            }
        }

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write(numero[linha, coluna] + "\t");
            }
            Console.WriteLine();
        }
    }
}