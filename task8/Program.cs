// метка, символизирует начало повторяющегося блока
begLoop:
Console.Clear();
Console.WriteLine("Введите число:");
string? a = Console.ReadLine();

int temp;
bool a_isNum = false;
int minNum = 1; 
string rezOut="";

if( a!=null)
{
  // проверяем что ввели цифры, а не что то другое и отмечаем во флагах
    if(int.TryParse(a,out temp))
    {
        a_isNum = true; 
    } else
    {
        Console.WriteLine("Вы ввели не число!!!");
        a_isNum = false; 
    }
//если числа, начинаем проверять на четность и записываем в rezOut 
if (a_isNum)
{
    while (minNum<=int.Parse(a))
    {
        if(minNum% 2==0)
        {
            rezOut+=" "+ minNum.ToString();
            if(minNum+1<int.Parse(a))
            { 
                rezOut+=",";
            }
        }
        minNum++;
    }
    //выводим ответ согласно задания
    Console.WriteLine($"{a} -> "+rezOut);
}else{
    Console.WriteLine("Перезапустите программу!!!");
}
// ввод новых чисел без перезапуска программы 
Console.WriteLine("Нажмите 0 если хотите повторить ввод!!!");
Console.WriteLine("Нажмите любую другую клавишу, чтобы выйти!!!");
string? return_to_start = Console.ReadLine();
// обработка исключения .. если мы просто жмакнем ентер ввместо ввода символа
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

