﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int number = Random.Shared.Next(1, 8);
Console.WriteLine(number);
if (number == 6){Console.WriteLine("да");}
else if (number == 7){Console.WriteLine("да");}
else Console.WriteLine("нет");
