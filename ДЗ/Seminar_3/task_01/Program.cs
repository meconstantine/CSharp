// Задача 1: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int value = Prompt("Введите пятизначное число < ");
if (value < 10000 || value > 99999)
{
    System.Console.WriteLine("Неверно задано число");
}
else
{
    int Palindrom(int value)
    {
        int N1 = value % 10;
        int N2 = value / 10 % 10;
        int N3 = value / 100 % 10;
        int N4 = value / 1000 % 10;
        int N5 = value / 10000;
        int palindrom = N1 * 10000 + N2 * 1000 + N3 * 100 + N2 * 10 + N1 * 1;
        if (value == palindrom)
        {
            System.Console.WriteLine($"{value} -> да");
        }
        else
        {
            System.Console.WriteLine($"{value} -> нет");
        }
        return palindrom;
    }
    Palindrom(value);
}

