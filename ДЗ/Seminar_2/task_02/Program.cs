// Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. 
// 456 -> 46
// 782 -> 72
// 918 -> 98

int value = new Random().Next(100, 1000);
int FirstDigit = value / 100 % 10;
int SecondDigit = value % 10;
int result = FirstDigit * 10 + SecondDigit;
System.Console.WriteLine($"{value} -> {result}");