// Задача 3: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
void PrintArray(int[] number)
{
    for (int i = 0; i < array.Length; i++)
    {
        number[i] = new Random().Next(0, 100);
        System.Console.Write($"{number[i]} ");
    }
    System.Console.WriteLine();
}

PrintArray(array);