/* 33. Задайте массив. Напишите прогу,
которая определяет есть ли заданное число в массиве*/

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
    Console.Write($"{array[i]} ");
}
int a;
Console.Write($"\nEnter number ");
int.TryParse(Console.ReadLine(), out a);


if (FindNumber(a, array))
    Console.Write($"Данное число найдено ");
else
    Console.Write($"Данного числа нет");


bool FindNumber(int b, int[] arr)
{
    foreach (var i in arr)
        if (b == i)
            return true;
    return false;
}
Console.Write($"\n{FindNumber} ");