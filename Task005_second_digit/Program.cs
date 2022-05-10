Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int number = int.Parse(Console.ReadLine());
if(number>99 && number<1000)
{
    do
    {
        number = number / 10;
        if(number < 100)
            {
                do
                    {
                        number = number - 10;
                        if (number < 10)
                        {
                            Console.WriteLine($"Вторая цифра числа: {number}");
                        }
                    }
                    while (number > 10);
            }
    }
    while (number > 100);
}
else
{
    Console.WriteLine("Некорректное значение");
}          