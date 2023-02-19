Console.Clear();
int ReadData(string WrDate)
{
    Console.WriteLine(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
int number = ReadData("Введите 5-значное число");
//первые 2 символа
int FirstRank = number / 1000;
//последние 2 символа
int SecRank = number % 100;

Dictionary<int, bool> dictPalindroms = new Dictionary<int, bool>();
//Заполняем наш словарик 
for (int i = 10; i <= 99; i++)
{
    int palindrom = i * 100 + (i % 10) * 10 + i / 10;
    dictPalindroms.Add(palindrom, true);
}
//проверка что число 5значное
if (number.ToString().Count() > 2 && number.ToString().Count() < 6)
{
    //проверяем есть ключик такой в нашем словарике или нет,  если проверять  dictPalindroms[FirstRank * 100 + SecRank] == true 
    //то нужно использовать try cach так как при отсутствии ключа вываливается ошибка что наше число was not present in the dictionary
    if (dictPalindroms.ContainsKey(FirstRank * 100 + SecRank))
    {
        Console.WriteLine($" {number} -> Число является палидромом");
    }
    else
    {
        Console.WriteLine($"{number} -> Число не является палидромом");
    }
}
else
{
    Console.WriteLine("В числе не 5 символов!!");
}