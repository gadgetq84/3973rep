using System;
using System.Linq;
Console.Clear();
int ReadData(string WrDate)
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

//Метод Фибоначчи
int Fib(int x)
{
    if (x == 0) return 0;
    int prev = 0;
    int next = 1;
    for (int i = 1; i < x; i++)
    {
        int sum = prev + next;
        prev = next;
        next = sum;
    }
    return next;
}
// Генеририруем наш массив
int[,] GenArry(int RowCount, int ColCount)
{

    int[,] binarray = new int[RowCount, ColCount];
    int k = 0;
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {
            binarray[i, j] = Fib(k);
            k++;

        }
    }
    return binarray;
}
//вывод массива 
void PrintArry(int[,] array)
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
//Поиск числа в массиве с выводом 
void FindNumInArry(int[,] array, int fnum)
{   //флажек для индикации нашли мы число в массиве или нет
    int flag = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == fnum)
            {
                flag = 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{array[i, j]}\t");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{array[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
    if (flag == 1)
    {
        Console.Write($"Число {fnum}:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Зелёненьковое!!!");
        Console.ResetColor();
    }
    else
    {
        Console.Write($"Число {fnum}:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Не найдено!");
        Console.ResetColor();
    }


}


int[,] array = GenArry(4, 5);
Console.WriteLine("Исходный массив:");
PrintArry(array);
int fnum = ReadData("Введите число для поиска:");
Console.WriteLine();
FindNumInArry(array, fnum);
