Console.Clear();
//method that implements the input of a number
string ReadData(string WrDate)
{
    Console.WriteLine(WrDate);
    string result = Console.ReadLine();
    return result;
}
//entering numbers
int numA = int.Parse(ReadData("Введите число A:" )?? "0");
char action = char.Parse(ReadData("Введите действие * / - + ^(возведение в степень):") ?? "0");
int numB = int.Parse(ReadData("Введите число B:") ?? "0");
//method that calculates values

double Calculate(double x, char opr, double y)
{
     switch(opr)
    {
        case '+':
            return x + y;
        case '-':
            return x - y;
        case '*':
            return x * y;
        case '/':
            return x / y;
        case '^':
            return Math.Pow(x,y);
        default:
            Console.WriteLine("Неизвестное действие");
            return 0.0;
    }
}
//result output format
Console.WriteLine($"{numA} {action} {numB} = {Calculate(numA,action,numB)}");