﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int number = n;
    if(number % 2 == 0) Console.WriteLine($"{number} - целое число");
    else Console.WriteLine($"{number} - не является целым числом");