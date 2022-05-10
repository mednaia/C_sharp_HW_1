Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int number = int.Parse(Console.ReadLine());
if(number>99)
{
    do
    {
        number = number / 10;
        if(number < 1000)
            {
                do
                    {
                        number = number - 10;
                        if (number < 10)
                        {
                            Console.WriteLine($"Третья цифра числа: {number}");
                        }
                    }
                    while (number > 10);
            }
    }
    while (number > 1000);
}
if(number < - 99)
{
    do
    {
        number = number / 10;
        if(number > - 1000)
            {
                do
                    {
                        number = number + 10;
                        if (number > - 10)
                        {
                            number = number * -1;
                            Console.WriteLine($"Третья цифра числа: {number}");
                        }
                    }
                    while (number < - 10);
            }
    }
    while (number < - 1000);
}
else
{
    Console.WriteLine("В данном числе нет третьей цифры");
}          