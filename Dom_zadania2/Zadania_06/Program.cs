// Задача 6
// Напишите программу, которая принимает на вход отрицательное четырехзначное число и на выходе показывает вторую цифру этого числа.
// -4356 -> 5
// -7282 -> 8 
// -9118 -> 1

int a = -9118;
Console.WriteLine("Дано: " + a);

int b = a / 10;
int c = b % 10;
Console.WriteLine("Второй элимент: " + (-1 * c));  // (-1*с) для получения положительного числа