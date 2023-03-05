
Console.Clear();
int ReadData(string WrDate)
{
    Console.WriteLine(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

double[,] GenArry(int min, int max, int RowCount, int ColCount)
{
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    double[,] binarray = new double[RowCount, ColCount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {

            binarray[i, j] = Math.Round(numSintezator.Next(min, max) - numSintezator.NextDouble(), 2);

        }
    }
    return binarray;
}
//вывод массива  с возможностью его раскрасить 
void PrintArry(double[,] array, bool colorise)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (colorise == true)
            {
                char[] symbarray = array[i, j].ToString().ToCharArray();
                for (int k = 0; k < symbarray.Length; k++)
                {
                    Console.ForegroundColor = col[new Random().Next(0, 16)];
                    Console.Write($"{symbarray[k]}");
                    Console.ResetColor();
                }
                Console.Write("\t");
            }
            else
            {
                Console.Write($"{array[i, j]}\t");
            }
        }
        Console.WriteLine();
    }

}



int row = ReadData("Введите кол-во строк");
int col = ReadData("Введите кол-во столбцов");
double[,] array = GenArry(20, 100, row, col);
Console.WriteLine("Исходный массив:");
PrintArry(array, false);

Console.WriteLine("Раскрашенный массив:");
PrintArry(array, true);