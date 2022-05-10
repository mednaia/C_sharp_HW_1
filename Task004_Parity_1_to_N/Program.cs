Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());
int start = 1;
int end = a;
while(start<=end)
{
    if(start % 2 == 0)
    {
        Console.WriteLine(start);
        start = start + 1;
    }
    else
    {
        start = start + 1;
    }
}