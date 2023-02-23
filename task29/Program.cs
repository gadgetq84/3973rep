string ReadData(string WrDate)
{
    Console.WriteLine(WrDate);

    string result = Console.ReadLine();
    if (result != null)
    {
        return result;
    }
    else
    {
        return "-1";
    }
}
string digArry = ReadData("Введите значение массива через запятую:");
string[] strArray = digArry.Split(",");

void CreateArry(string[] strArray)
{
    Console.Write("[");
    for (int i = 0; i < strArray.Length - 1; i++)
    {
        Console.Write($"{strArray[i]},");
    }
    Console.Write($"{strArray[strArray.Length - 1]}]");
}
Console.Write($"{digArry}->");
CreateArry(strArray);

//рандомный индекс массива
Random rnd1 = new Random();
Console.WriteLine(rnd1.Next(1,strArray.Length)-1); 
