Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int number = int.Parse(Console.ReadLine());
if(number < 100)
    Console.WriteLine("В данном числе нет третьей цифры");
int third = (number % 1000)/100;
Console.WriteLine($"Третья цифра числа с конца {third}");
