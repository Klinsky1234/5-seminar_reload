﻿/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
int a = 0;
int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10, 50);
    Console.Write($"{array[i]} ");
}
Console.WriteLine($"->");
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) a = a + array[i];
}
Console.WriteLine($"сумма эл. стоящих на нечётных поз: -> {a}");
