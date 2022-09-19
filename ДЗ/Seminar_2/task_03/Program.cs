// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int value = Prompt("Введите число < ");
if (value > 99)
{
    int temp = value / 1;
    int min = 999;
    while (temp > min)
    {
        temp = temp / 10;
    }
    int result = temp % 10;
    System.Console.WriteLine($"{value} -> {result}");
}
else
{
    System.Console.WriteLine($"{value} -> Нет третьей цифры");
}