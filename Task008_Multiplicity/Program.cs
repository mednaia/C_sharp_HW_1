Console.WriteLine("Введите первое число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите клавишу Enter: ");
int b = int.Parse(Console.ReadLine());
int rem = 1;
if(a % b == 0)
{
    Console.WriteLine($"{a} кратно {b}");
}
else
{
    rem = a % b;
    Console.WriteLine($"{a} не кратно {b}. Остаток от деления {rem}");
}