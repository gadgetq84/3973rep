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
//метод упорядочивания по убыванию
void DescendingOrderRow(int[,] array)
{
    int[] temp = new int[array.GetLength(1)];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            temp[j] = array[i, j];
        }
        //вызываем наш метод пузырьковый
        int[] sortedRow = SortArrayBubles(temp);
        
        for (var k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = sortedRow[k];
        }
    }
}
//метод пузырьковый
int[] SortArrayBubles(int[] array)
{
    int[] result = array;
    int arrlen = result.Length;
    int buf = result[0];
    for (int j = 0; j < arrlen; j++)
    {
        for (int i = 0; i < arrlen - 1 - j; i++)
        {
            if (result[i] < result[i + 1])
            {
                buf = result[i + 1];
                result[i + 1] = result[i];
                result[i] = buf;
            }
        }
    }
    return result;
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
int[,] array = GenArry(10, 100, 6, 7);
//выводим массив
Console.WriteLine("Исходный массив:");
Print2DArry(array);
Console.WriteLine();
//упорядочиваем 
DescendingOrderRow(array);
//выводим массив
Console.WriteLine("Упорядоченный  по убыванию:");
Print2DArry(array);