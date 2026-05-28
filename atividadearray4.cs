public static class atividadearray4
{
    public static void Executar()
    {
        int[] nota = new int[4];
        double media = 0;

        for (int contador = 0; contador < 4; contador++)
        {
            Console.WriteLine($"digite a {contador + 1} ° nota: ");
            nota[contador] = int.Parse(Console.ReadLine()!);
            media += nota[contador];
        }

        Console.WriteLine($"A média final é {media / 4}");

    }
}