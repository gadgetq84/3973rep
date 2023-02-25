Console.Clear();
//generate our array
int[] GenArry(int min, int max, int indexcount)
{
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    int[] binarray = new int[indexcount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < indexcount; i++)
    {
        binarray[i] = numSintezator.Next(min, max);
    }
    return binarray;
}
//output array to console
void PrintArry(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}
//search for pairs of numbers
void FindPairsOfNumArry(int[] array)
{
    int arrlen = array.Length;
    for (int j = 0; j < arrlen; j++)
    {
        for (int i = 1; i < arrlen; i++)
        {//exclude excess from the results
            if (array[j] == array[i] && j != i && j < i)
            {
                //print to the console pairs
                Console.WriteLine($"Найдены пары: {array[j]} позиция {j} и {array[i]} позиция {i}");
            }
        }
    }
}
//output of the original array
int[] array = GenArry(-100, 100, 15);
Console.Write("Исходный массив:");
PrintArry(array);
FindPairsOfNumArry(array);
