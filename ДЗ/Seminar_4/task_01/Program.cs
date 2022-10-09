// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int A = Prompt("Введите число > ");
int B = Prompt("Введите число > ");

if (B < 0)
{
    System.Console.WriteLine("Неверно задана степень");
}
else
{
    int Degree(int value)
    {
        int power = value;
        if (B == 0)
        {
            return 1;
        }
        for (int i = 1; i < B; i++)
        {
            power *= value;
        }
        return power;
    }
System.Console.WriteLine(Degree(A));
}