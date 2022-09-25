// Задача 3: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Cube(int N)
{
    for (int i = 1; i <= N; i++)
    {
        System.Console.WriteLine($"Куб числа {i} - это {i * i * i}");
    }
}

int N = Prompt("Введите число > ");
Cube(N);