// метка, символизирует начало повторяющегося блока
begLoop:
Console.Clear();
//объявляем массив строк
string[] in_refs=new string[3];
// ждем ввода 3-х цифр
for(int i=0;i<3;i++)
{
    Console.WriteLine($"Введите число {i+1}:");
    in_refs[i] = Console.ReadLine();
}

int temp;
//объявляем массив булевый
bool[] isNum = new bool[3];
//предположим что первая введеная цифра максимальная и запишем ее в max 
string max = in_refs[0];
//проверяем что значения не нулевые
if( in_refs[0]!=null && in_refs[1]!=null && in_refs[2]!=null)
{
    // в цикле проверяем что ввели цифры, а не что то другое и отмечаем во флагах
    for(int i=0;i<3;i++)
    {
        if(int.TryParse(in_refs[i],out temp))
        {
            isNum[i] = true; 
        } 
        else
        {
            Console.WriteLine($"Переменная {i}  не число!!!");
            isNum[i] = false; 
        }
    }
//если числа, начинаем их сравнивать
    if (isNum[0] && isNum[1] && isNum[2])
    {
        for(int i=0;i<isNum.Count()-1;i++)
        {
            if (int.Parse(in_refs[i])>int.Parse(in_refs[i+1]))
            {
                max=in_refs[i];
            }else
            {
                max=in_refs[i+1];
            }
        }
        // вывод наших чисел и максимального  из них.
        Console.WriteLine($"{in_refs[0]} {in_refs[1]} {in_refs[2]} -> {max}");
    }
     else
    {
        Console.WriteLine("Перезапустите программу!!!");
    }
// ввод новых чисел без перезапуска программы 
Console.WriteLine("Нажмите 0 если хотите ввести новые цифры!!!");
Console.WriteLine("Нажмите любую другую кнопку чтобы выйти!!!");
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
