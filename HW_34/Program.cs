/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write($"{array[i]} ");
}
Console.WriteLine($"->");
int b = 0;
for (int i = 0; i < array.Length; i++)
{
    int a = 0;

    if (array[i] % 2 == 0)
    {
        a += array[i];
        Console.Write($"{a} ");
        b++;
    }
    else
    {
        Console.Write($"x ");
    }
}
Console.WriteLine($"\nКоличество чётных чисел-> {b}");
