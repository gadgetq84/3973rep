int ReadData(string WrDate)
{
    Console.WriteLine(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int number = ReadData("Введите число:");

int SumofDigitsVar1(int num)
{
    int buf = num;
    int sum = 0;
    do
    {
        //We write in the amount
        sum = sum + (buf % 10);
        // the number 1 bit less is written to the buffer
        buf = buf / 10;
        //as soon as buf becomes less than zero, we end the loop 
    } while (buf > 1);
    return sum;
}

int SumofDigitsVar2(int num)
{
    char [] chrnumarry=num.ToString().ToCharArray();
    int index=0;
    int sum = 0;
    
    while(index<chrnumarry.Count())
    {
        sum +=int.Parse(chrnumarry[index].ToString());
        index++;
    }
    return sum;
}
DateTime d1 = DateTime.Now;
Console.WriteLine($"{SumofDigitsVar1(number)} -> {number}");
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
Console.WriteLine($"{SumofDigitsVar2(number)} -> {number}");
Console.WriteLine(DateTime.Now - d2);
