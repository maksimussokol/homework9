Console.Clear();


Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

int Aker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Aker(m - 1, 1);
    }
    return Aker(m - 1, Aker(m, n - 1));
}

Console.WriteLine(Aker(m, n));