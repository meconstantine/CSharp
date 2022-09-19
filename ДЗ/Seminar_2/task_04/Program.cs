// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int value = new Random().Next(1, 8);
if (value >= 1 && value <= 5)
{
    System.Console.WriteLine($"{value} -> нет");
}
else
{
    System.Console.WriteLine($"{value} -> да");
}