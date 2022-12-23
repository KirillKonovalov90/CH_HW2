int Print_3rd_digit(int number)
{
    int digit;

    if (number < 99)
    {
        digit = -1;
    }       
    else
    {
        while (number > 999)
        {
            number = number / 10;
        }
        digit = number % 10;           
    }
    return digit;
}

int result, num;
Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine()!);

result = Print_3rd_digit(num);

if (result != -1)
{
    Console.Write(result);
}
else
{
    Console.Write("У числа отсутствует 3я цифра");
}

