﻿// Задача 3
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


int a = 34;
int b = 5;

if (a % b == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно, остаток: " + a % b);
}
