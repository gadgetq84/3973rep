// метка, символизирует начало повторяющегося блока
begLoop:
Console.Clear();
string? test1 = Console.ReadLine();
int test = -1;
if(test1!=null && test1.Length>0)
{
 test = Convert.ToInt32(test1);
}
Console.WriteLine(test1.Length);

Console.WriteLine("Введите число a:");
string? a = Console.ReadLine();

Console.WriteLine("Введите число b:");
string? b = Console.ReadLine();
int temp;
bool a_isNum = false;
bool b_isNum = false;

if( a!=null && b!=null)
{
  
    if(int.TryParse(a,out temp))
    {
        a_isNum = true; 
    } else
    {
        Console.WriteLine("Переменная 'а'  не число!!!");
        a_isNum = false; 
    }

    if(int.TryParse(b,out temp))
    {
        b_isNum = true;        
    } else
    {
         Console.WriteLine("Переменная 'b'  не число!!!");
          b_isNum = false;
    }

if (a_isNum && b_isNum)
{
    if(int.Parse(a)>int.Parse(b))
    {
        Console.WriteLine($"a = {a} b= {b} -> Max = {a}");
    }else
    {
        Console.WriteLine($"a = {a} b= {b} -> Max = {b}");
    }

}else{
    Console.WriteLine("Перезапустите программу!!!");
}

Console.WriteLine("Нажмите 0 если хотите ввести новую пару цифр!!!");
string? return_to_start = Console.ReadLine();
try
{
if( return_to_start!=null )
    {
        if (int.Parse(return_to_start)==0) 
        {   
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

