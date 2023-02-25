Console.Clear();
// Console output
void PrintData(string text, double print)
{
    Console.WriteLine($"{text}:{print}");
}
//generate our array
double[] GenArry(int min, int max, int indexcount)
{
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    double[] binarray = new double[indexcount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < indexcount; i++)
    {
        //генератов вещественного массива
        binarray[i] = Math.Round(-min + numSintezator.NextDouble()*(min+max),2);
    }
    return binarray;
}
//output array to console
void PrintArry(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]};");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}
//search for pairs of numbers
(double min, double max) FindMinMaxArry(double[] array)
{
    double arrlen = array.Length;
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < arrlen; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else
        {
            max = array[i];
        }

    }

    return (min, max);
}
//insertion sort
void SortInsertArry(double[] array)
{ 

    for (int i = 1; i < array.Length; i++)
    {
        double k = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > k)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = k;
    }

}
//output of the original array
double[] array = GenArry(1, 100, 15);
Console.Write("Исходный массив:");
PrintArry(array);
Console.Write("Сортировка методом вставки:");
SortInsertArry(array);
PrintArry(array);

(double min, double max) result = FindMinMaxArry(array);
PrintData("Минимальное значение", result.min);
PrintData("Максимальное значение", result.max);
PrintData("Разница max-min", result.max - result.min);
