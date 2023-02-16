//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("ВВедите число");
int x_digit_num = int.Parse(Console.ReadLine() ?? "0");
//объявляем массив 
int[] digit_num_arry = new int[0];
//иднекс массива по умолчанию 0
int index = 0;
//буфер для наших манипуляций с цифирками
int buf = x_digit_num;
do
{
    // записывем крайнюю правую цифру в массив
    digit_num_arry = digit_num_arry.Concat(new int[] { buf % 10 }).ToArray();
    // цифру на 1 разряд меньше записываем в буферок
    buf = buf / 10;
    // стчетчик разрядов
    index++;
    //как только buf станет меньше нуля заканчиваем цикл  
} while (buf > 1);
// проверяем сколько разрядов и выводин по условию задачи что надо
if (index > 2)
{
    Console.WriteLine($"{x_digit_num} -> {digit_num_arry[index - 1 - 2]}");
}
else
{
    Console.WriteLine($"{x_digit_num} -> третьей цифры нет");
}


