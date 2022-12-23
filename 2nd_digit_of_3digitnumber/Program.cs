void Second_digit_of_3 (int number)
{
    int digit;

    if (number > 99 & number < 1000)
    {
        digit = number % 100;
        digit = digit / 10;
        Console.Write($"Вторая цифра числа = {digit}");
    }
    else
    {
        Console.Write("Вы ввели не трёхзначное число");
    }
}

int num;

Console.Write("Введите трёхзначное число: ");
num = int.Parse(Console.ReadLine()!);

Second_digit_of_3 (num);