int numeroDecimal = 89;
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

System.Console.WriteLine(numerosUm);