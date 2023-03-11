// метод Аккермана 
uint Akkerman(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

// метод ввода 
uint ReadData(string WrDate)
{
    Console.Write(WrDate);
    uint result = uint.Parse(Console.ReadLine() ?? "0");
    return result;
}

Console.Clear();

uint m = ReadData("Введите m:");
uint n = ReadData("Введите n:");
//проверяем что m меньше n если не так меняем местами
if (m >= 0 && n >= 0)
{
    uint res = Akkerman(m, n);
    // ..вывод
    Console.WriteLine($"Результат работы функции Аккермана: {res}");
}
else
{
    Console.WriteLine($"Числа не положитльные!!!");
}