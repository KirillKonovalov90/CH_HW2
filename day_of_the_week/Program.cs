void Number_to_day_of_the_week(int number)
{
    if (number > 5 && number <= 7)
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}

int num;

Console.Write("Введите номер дня недели, проверим выходной ли он: ");
num = int.Parse(Console.ReadLine()!);

if (num < 1 || num > 7 )
{
    Console.WriteLine($"Число {num} некорректно для дня недели, введите от 1 до 7");    
}
else
{
    Number_to_day_of_the_week(num);
}