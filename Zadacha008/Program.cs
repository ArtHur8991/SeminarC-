﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


int num = new Random().Next(1, 60);
int i = 0;
Console.WriteLine(num);
while (i <= num)
{
    if (i % 2 ==0)
    Console.Write(i);
    Console.Write(" ");
    i++;
}