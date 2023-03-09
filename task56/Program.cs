int[,] GenArry(int min, int max, int RowCount, int ColCount)
{
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    int[,] binarray = new int[RowCount, ColCount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {

            binarray[i, j] = numSintezator.Next(min, max);

        }
    }
    return binarray;
}
//считаем суммы строк и записываем в новый массив
int[] SumOfNumbersInAString(int[,] array)
{

    int[] sum = new int[array.GetLength(0)];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}
// ищем индекс наименьшей суммы
int GetMinElemArry(int[] arry)
{
    int index = 0;
    int min = arry[0];
    for (var i = 1; i < arry.Length; i++)
    {
        if (min > arry[i])
        {
            min = arry[i];
            index = i;
        }
    }
    return index;
}


//вывод нашего массива
void Print2DArry(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write($"{array[i, j]}\t");

        }
        Console.WriteLine();
    }

}
//генерируем наш массив
int[,] array = GenArry(10, 100, 7, 5);
//выводим массив
Console.WriteLine("Исходный массив:");
Print2DArry(array);
Console.WriteLine();
//считаем суммы в строках
int[] sumrow = SumOfNumbersInAString(array);
//возвращает индекс минимальной суммы
int index = GetMinElemArry(sumrow);
//выводим результат
Console.WriteLine($"номер строки с наименьшей суммой элементов:{index} строка");
