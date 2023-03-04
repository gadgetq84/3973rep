int ReadData(string WrDate)
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

//вывод чего-то 
void PrintData(string text, string print)
{
    Console.WriteLine($"{text}:{print}");
}
// находим точки пересечения
(double x, double y) PointIntersect(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    return (x, y);
}
//вычисление площади
double SquareTriangle((double x, double y) res1,(double x, double y) res2,(double x, double y) res3)
{
    double resultS= 0.5 * Math.Abs((res2.x-res1.x)*(res3.y-res1.y) + (res3.x-res1.x)*(res2.y-res1.y));
    return resultS;
}

int b1 = ReadData("Введите b1:");
int k1 = ReadData("Введите k1:");

int b2 = ReadData("Введите b2:");
int k2 = ReadData("Введите k2:");

int b3 = ReadData("Введите b3:");
int k3 = ReadData("Введите k3:");

(double x, double y) res1 = PointIntersect(b1,k1,b2,k2);
(double x, double y) res2 = PointIntersect(b2,k2,b3,k3);
(double x, double y) res3 = PointIntersect(b3,k3,b1,k1);

Console.WriteLine("Точки пересечения прямых:");
Console.Write(res1.x+";");
Console.WriteLine(res1.y);

Console.Write(res2.x+";");
Console.WriteLine(res2.y);

Console.Write(res3.x+";");
Console.WriteLine(res3.y);


PrintData("Площадь треугольника",SquareTriangle(res1,res2,res3).ToString());
