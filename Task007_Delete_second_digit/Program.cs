Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int number = int.Parse(Console.ReadLine());
if(number>99 && number<1000)
{
    int numberA = number / 100;
    int numberC = number % 10;
    int newNumber = (numberA*10) + numberC;
    Console.WriteLine(newNumber);
}
else
{
    Console.WriteLine("Некорректное значение");
}          