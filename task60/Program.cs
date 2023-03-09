//Генерация трёхмерных массив
int[,,] Gen3DArry(int min, int max, int xCount, int yCount, int zCount)
{
    int buf;
    int t = 0;
    int[] randomNum = new int[xCount * yCount * zCount];
    int[,,] binarray = new int[xCount, yCount, zCount];
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    //вызов метода возвращающего массив неповторяющихся двузначных чисел 
    randomNum = GenRandomArry(randomNum.GetLength(0));

    for (int i = 0; i < xCount; i++)
    {
        for (int j = 0; j < yCount; j++)
        {
            for (int k = 0; k < zCount; k++)
            {
                //заполняем массив
                binarray[i, j, k] = randomNum[t];
                t++;                
            }
        }
    }
    return binarray;
}
//сам метод генерации неповторяющихся двузначных чисел 
int[] GenRandomArry(int len)
{
    System.Random numSintezator = new System.Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        int r = numSintezator.Next(10, 100);
        if (!(arr.Contains(r)))
        {
            arr[i] = r;
        }
        else
        {
            i--;
        }
    }
    return arr;
}
// вывод массива на экран
void Print3DArry(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k})\t");
            }
        }
    }

}
//генерируем наш массив
int[,,] array1 = Gen3DArry(1, 10, 2, 2, 2);
//выводим массив
Console.WriteLine("Исходный массив:");
Print3DArry(array1);
Console.WriteLine();

