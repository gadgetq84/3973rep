Console.Clear();
//The user enters the number of clicks, 
//then the program monitors the clicks and returns 
//how many numbers greater than 0 were entered.
int ReadData(string WrDate)
{
    Console.WriteLine(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
//ввод нашей строки из N кол-ва символов
string ReadString(string WrDate,int count)
{
    Console.WriteLine($"{WrDate} {count} символов.");
    string result ="";
    
    for (var i = 0; i < count; i++)
    {
         result += (Console.ReadKey(true)).KeyChar;
    } 

    return result;
}
//подсчитываем сколько цифр в нашей строке
int CountOfDigits(string str)
{
    char [] strarry = str.ToCharArray();
    int test;
    int count = 0;
    for (var i = 0; i < strarry.Length; i++)
    {
        if(int.TryParse(strarry[i].ToString(),out test) && int.Parse(strarry[i].ToString())>0)
        {
            count+=1;
        }
    }
    
    return count;
}
//вывод чего-то 
void PrintData(string text, string print)
{
    Console.WriteLine($"{text}:{print}");
}

int strcount = ReadData("Введите число нажатий:");
string ResStr = ReadString("Введите", strcount);

PrintData("Исходная строка", ResStr);
PrintData("Колличество цифр больше нуля",(CountOfDigits(ResStr)).ToString());