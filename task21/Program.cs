Console.Clear();
//ввод координат
int ReadData(string WrDate)
{
    Console.WriteLine(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
//вычисляем расстояние между точками
double getDstBtPnts(int[] point_d1, int[] point_d2)
{
    double result = Math.Sqrt(Math.Pow((point_d2[0] - point_d1[0]), 2) + Math.Pow((point_d2[1] - point_d1[1]), 2) + Math.Pow((point_d2[2] - point_d1[2]), 2));
    return result;
}

int[] point1 = new int[3];

point1[0] = ReadData("Введите координату X первой точки");
point1[1] = ReadData("Введите координату Y первой точки");
point1[2] = ReadData("Введите координату Z первой точки");
int[] point2 = new int[3];
point2[0] = ReadData("Введите координату X второй точки");
point2[1] = ReadData("Введите координату Y второй точки");
point2[2] = ReadData("Введите координату Z второй точки");

///проверяем длины наших массивов
if (point1.Length == 3 && point2.Length == 3)
{
   Console.WriteLine($"A({point1[0]},{point1[1]},{point1[2]}); B({point2[0]},{point2[1]},{point2[2]});-> {getDstBtPnts(point1, point2)}");
}
else
{
    Console.WriteLine("Что то не то с входными параметрами!!!");
}