
public static class atividadearray5
{
    public static void Executar()
    {
        double[] valor = new double[5];
        double maior = 0;

        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"digite o número {contador + 1} ");
            valor[contador] = double.Parse(Console.ReadLine()!);

        }

        maior = valor[0];
        for (int verificar = 0; verificar < 4; verificar++)
        {

            if (maior < valor[verificar + 1])
            {
                maior = valor[verificar + 1];
            }
        }

        Console.WriteLine($"O maior valor é {maior}");

    }
}