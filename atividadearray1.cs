public static class atividadearray1
{
    public static void Executar()
    {
        string[] aluno = new string[5];
        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"digite o nome do {contador + 1} ° aluno: ");
            aluno[contador] = Console.ReadLine()!;
        }
        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"O nome do {contador + 1} ° aluno é {aluno[contador]} ");
        }

    }
}