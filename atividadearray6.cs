
using System.ComponentModel;

public static class atividadearray6
{
    public static void Executar()
    {
        int[] numero = new int[5];
        int maior = 0;
        int suporte = 0;

        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"digite o {contador + 1} número: ");
            numero[contador] = int.Parse(Console.ReadLine()!);

        }

        maior = numero[0];
        for (int verificar = 0; verificar < 4; verificar++)
        {
            for (int organizar = 0; organizar < 4; organizar++)

                if (numero[organizar] > numero[organizar + 1])
                {
                    suporte = numero[organizar + 1];
                    numero[organizar + 1] = numero[organizar];
                    numero[organizar] = suporte;
                }
        }
        for (int listar = 0; listar < 5; listar++)
        {
            Console.Write($"{numero[listar]} - ");
        }

    }
}