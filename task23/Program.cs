Console.Clear();
//Вычисляем наших чисел в нужной степени
double []  GetCubedNum(int number, int pow)
{
    double [] result = new double[number];
    for (int i = 1; i <= number; i++)
    {
        result[i - 1] = Math.Pow(i, pow);
    }
    return result;
}
//метод реализующий ввод числа
int ReadData(string WrDate)
{
    Console.WriteLine(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
//ввод числа
int num = ReadData("Введите число:");
// вывод наших чисел в 3 степени 
double[] coubnum = GetCubedNum(num, 3);
// вывод наших чисел в 3 степени 
double[] numarray = GetCubedNum(num, 1);

//формируем вывод
Console.WriteLine("Число\tКуб");
for (int i = 0; i < num; i++)
{
    Console.WriteLine("{0}\t{1}", numarray[i], coubnum[i]);
}