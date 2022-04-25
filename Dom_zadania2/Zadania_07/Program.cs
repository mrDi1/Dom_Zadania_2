// Задача 7
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int a = 32679;
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());     // Преабразоваем наше число в массив
}

if (b.Length >= 3)
{
    Console.WriteLine("Трети элимент: " + b[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}