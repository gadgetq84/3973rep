Console.Clear();
// метод ввода 
int ReadData(string WrDate)
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
//метод подсчета суммы 
int RecSumMn(int m, int n)
{
    int result = 0;


    if (m >= n)
    {
        result += n;
    }
    else
    {
        result = result + m + RecSumMn(m + 1, n);
    }
    return result;
}

int m = ReadData("Введите n:");
int n = ReadData("Введите m:");
//проверяем что m меньше n если не так меняем местами
int res = m < n ? RecSumMn(m, n) : RecSumMn(n, m);
// ..вывод
Console.WriteLine($"Сумма чисел от M до N={res}");