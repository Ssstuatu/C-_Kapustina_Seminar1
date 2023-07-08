// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число: ");
double numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double numberB = int.Parse(Console.ReadLine());
double max = numberA;
    if(numberB > max) Console.WriteLine($"max равно {numberB}, min равно {numberA} ");
    else Console.WriteLine($"max равно {numberA}, min равно {numberB}");