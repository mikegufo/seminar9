int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void SumPrint(int M, int N)
{
    Console.Write(SumMN(M - 1, N));
}

int SumMN(int M, int N)
{
    int res = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        res = M + SumMN(M, N);
        return res;
    }
}


int M = ReadInt("Начальное");
int N = ReadInt("Конечное");
SumPrint(M, N);
