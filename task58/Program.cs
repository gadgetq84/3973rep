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

// метод умножения двух матриц
int[,] MultiArrys(int[,] arry1, int[,] arry2)
{
    if ((arry1.GetLength(0) != arry2.GetLength(0)) || (arry1.GetLength(1) != arry2.GetLength(1)))
    {
        throw new Exception("Для матриц с разным размером сложение не возможно!");
    }

    int[,] arry3 = new int[arry1.GetLength(0), arry2.GetLength(1)];

    for (var i = 0; i < arry1.GetLength(0); i++)
    {
        for (var j = 0; j < arry2.GetLength(0); j++)
        {
            arry3[i, j] = 0;

            for (var k = 0; k < arry1.GetLength(1); k++)
            {
                arry3[i, j] += arry1[i, k] * arry2[k, j];
            }

        }
    }

    return arry3;
}

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
int[,] array1 = GenArry(1, 10, 3, 3);
int[,] array2 = GenArry(1, 10, 3, 3);
//выводим массив
Console.WriteLine("Исходные массивы:");
Print2DArry(array1);
Console.WriteLine();
Print2DArry(array2);
Console.WriteLine();
//умножаем матрицы
int[,] multiMatrix = MultiArrys(array1, array2);
Console.WriteLine("Результирующая матрица:");
//выводим результат
Print2DArry(multiMatrix);
