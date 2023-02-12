// метка, символизирует начало повторяющегося блока
begLoop:
Console.Clear();
Console.WriteLine("Введите число:");
string? a = Console.ReadLine();

int temp;
bool a_isNum = false;


if( a!=null)
{
   // проверяем что ввели цифры, а не что то другое и отмечаем во флагах
    if(int.TryParse(a,out temp))
    {
        a_isNum = true; 
    } else
    {
        Console.WriteLine("Переменная не число!!!");
        a_isNum = false; 
    }
//если числа, начинаем проверку на четность
if (a_isNum)
{
    if(int.Parse(a) % 2==0)
    {
        Console.WriteLine($"{a} -> да четное");
    }else
    {
        Console.WriteLine($"{a} -> нет не Четное");
    }

}else{
    Console.WriteLine("Перезапустите программу!!!");
}
// ввод новых чисел без перезапуска программы 
Console.WriteLine("Нажмите 0 если хотите повторить ввод!!!");
Console.WriteLine("Нажмите любую другую клавишу, чтобы выйти!!!");
string? return_to_start = Console.ReadLine();
try
{
if( return_to_start!=null )
    {
        if (int.Parse(return_to_start)==0) 
        {   
            // в случае совпадения переходим к началу нашей программы
            goto begLoop;
        }
    } else
    {
        Console.WriteLine("Пока!!!");
    }
}catch
{
    Console.WriteLine("Пока!!!");
}

}
