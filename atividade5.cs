public static class atividade5
{
    //exercício 3 com uso do for
    public static void Executar()
    {
        for (int contador = 1; contador <= 10; contador++)
        {
            Console.WriteLine(contador);
        }
    }
}

//exercício 3 usando while

public static class atividade
{
    //exercício 3 com uso do for
    public static void Executar()
    {
        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }
    }
}

//A versão com for ficou mais organizada porque o contador, a condição e o incremento ficam todos na mesma linha, deixando o código mais limpo e fácil de entender. já o while também funciona corretamente, mas precisa criar e incrementar a variável separadamente, deixando o código um pouco maior.