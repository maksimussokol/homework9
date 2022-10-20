Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

int first = n;
int last = m;

if (n > m)
{
    first = m;
    last = n;
}

int FindSum(int poslednee)
{
    if (poslednee == 0) return 0;
    else return poslednee + FindSum(poslednee - 1);
}
Console.WriteLine($" summa ot pervogo do poslednego = {FindSum(last) - FindSum(first - 1)}");
