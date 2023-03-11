// Метод ввода данных 
int ReadData(string WrDate)
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
//вывод чисел по возрастанию
string LineGenRec(int num)
{
    if (num == 1)
    {
        return "1";
    }
    else
    {

        return LineGenRec(num - 1) + " " + num.ToString();
    }
}
Console.Clear();
//ввели число
int N = ReadData("Введите N:");
//Вызвали наш метод
string str = LineGenRec(N);
// вывели на экран
Console.WriteLine(str);