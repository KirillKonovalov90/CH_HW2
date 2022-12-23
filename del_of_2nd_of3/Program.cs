void del_the_2nd_of_3randommed()
{
    int number, result, first, last;

    number = new Random().Next(100, 1000);     
    first = number / 100 * 10;
    last = number % 10;
    result = first + last;
    Console.Write($"Из числа {number} удаляем 2ю цифру, получаем: {result}");
}

del_the_2nd_of_3randommed();