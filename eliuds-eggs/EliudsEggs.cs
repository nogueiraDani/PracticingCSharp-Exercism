using Xunit.Sdk;
using System;
using System.Collections.Generic;

public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        if (encodedCount == 0)
        {
            return 0;
        }
        else
        {
            int numeroDecimal = encodedCount;
            var binarioInvertido = new List<int>();

            do
            {
                int resultado = numeroDecimal / 2;
                if (numeroDecimal % 2 == 0)
                {
                    binarioInvertido.Add(0);
                }
                else
                {
                    binarioInvertido.Add(1);
                }
                numeroDecimal = resultado;
            } while (numeroDecimal >= 2);

            binarioInvertido.Add(1);
            binarioInvertido.Reverse();

            int numerosUm = 0;

            foreach (int num in binarioInvertido)
            {
                if (num == 1)
                {
                    numerosUm++;
                }
            }
            return numerosUm;
        }

    }

}





