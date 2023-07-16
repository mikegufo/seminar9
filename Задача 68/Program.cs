int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void SumPrint(int M, int N)
{
    Console.Write(Akkerman(M, N));
}

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return (Akkerman(M - 1, Akkerman(M, N - 1)));
    }
}

int M = ReadInt("Начальное");
int N = ReadInt("Конечное");
SumPrint(M, N);
