int number = new Random().Next(10, 99);
Console.WriteLine(number);
int numberA = number / 10;
int numberB = number % 10;
Console.WriteLine($"Первая цифра числа: {numberA}");
Console.WriteLine($"Вторая цифра числа: {numberB}");
int max = numberA;
int min = numberB;
if(numberA > numberB)
     Console.WriteLine($"Max: {numberA}  Min: {numberB}");
else 
     Console.WriteLine($"Max: {numberB}  Min: {numberA}");