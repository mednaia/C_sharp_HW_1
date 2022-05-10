Console.WriteLine("Введите первое число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите клавишу Enter: ");
int b = int.Parse(Console.ReadLine());
if(a == b * b)
{
    Console.WriteLine($"{a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"{a} НЕ является квадратом числа {b}");
}