﻿// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3; // мы же здесь пока без массивов работаем?

Console.WriteLine($"Максимальное число равно = {max}.");