public static class atividadearray3
{
    public static void Executar()
    {
        int[] numero = new int[5];
        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"digite o {contador + 1} ° número: ");
            numero[contador] = int.Parse(Console.ReadLine()!);
        }

        int soma = 0;

        for (int contador = 0; contador < 5; contador++)
        {
            soma = soma + numero[contador];
        }

        Console.WriteLine($"Soma: {soma}");


        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"O {contador + 1} ° número é {numero[contador]} ");
        }

    }
}