public static class atividadearray2
{
    public static void Executar()
    {
        string[] numero = new string[6];
        for (int contador = 0; contador < 6; contador++)
        {
            Console.WriteLine($"digite o {contador + 1} ° número: ");
            numero[contador] = Console.ReadLine()!;
        }
        for (int contador = 0; contador < 6; contador++)
        {
            Console.WriteLine($"O {contador + 1} ° número é {numero[contador]} ");
        }

    }
}