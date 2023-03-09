// создание массива
int[,] GenArry(int RowCount, int ColCount)
{
    int[,] binarray = new int[RowCount, ColCount];
    int buf = 0;
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {
            buf = SpiralFilling(RowCount, ColCount, j, i);
                binarray[i, j] = (buf);
        }
    }
    return binarray;
}

//Метод заполнения массива по спирали
int SpiralFilling(int w, int h, int x, int y)
{
    if (y != 0)
    {
        return w + SpiralFilling(h - 1, w, y - 1, w - x - 1);
    }
    else return x + 1;
}

//Печать 2-х мерного массива 
void Print2DArry(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write($"{array[i, j]:D2}\t");

        }
        Console.WriteLine();
    }

}
//Генерируем матрицу
int[,] array = GenArry(4, 4);
Console.WriteLine("Матрица 2x2  заполнена по спирали:");
//выводим в куонсоль матрицу
Print2DArry(array);