//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("ВВедите 3-х значное число");
int three_digit_num = int.Parse(Console.ReadLine() ?? "0"); ;
int varlen = three_digit_num.ToString().Length;
if (varlen == 3)
{
    //нашли крайнюю левую цифру
    int Num_one = three_digit_num / 100;
    // нашли крайнюю правую 
    int Num_three = three_digit_num % 10;
    //не много математики и есть цифра в середине
    int Num_two = (three_digit_num - (Num_one * 100 + Num_three)) / 10;
    // выводим в консоль
    Console.WriteLine($"{three_digit_num} -> {Num_two}");
}
else
{
    Console.WriteLine($"ВВели не 3-х значное число, а {varlen} значное!!!");
}
