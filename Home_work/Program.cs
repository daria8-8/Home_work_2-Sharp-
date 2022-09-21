void Ex10()
{
Console.WriteLine("Введите трёхзначное число : ");
int a = int.Parse(Console.ReadLine());
int result = ((a / 10) % 10);
Console.Write(result);
}

void Ex13()
{
Console.WriteLine("Введите число : ");
int a = int.Parse(Console.ReadLine());
if (a < 99) //if (a / 100 == 0)
    {
        Console.Write("Третьей цифры нет");
    }
else
    {
        Console.Write(a.ToString()[2]);
    }
}

void Ex15()
{
Console.WriteLine("Введите цифру обозначающую день недели, от 1 до 7 : ");
int a = int.Parse(Console.ReadLine());
if (a < 6)
    {
        Console.Write("Нет, это будний день");
    }
else
    {
        Console.Write("Да, день выходной");
    }
}

Ex15();
