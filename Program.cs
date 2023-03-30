/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76 */

int a = 0;
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10, 50);
    Console.Write($"{array[i]} ");
}
int min = array[0]; int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}
Console.Write($"\n min = {min} / max = {max}");
int mm = max - min;

Console.WriteLine($" -> {mm}");