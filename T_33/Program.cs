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
int b = 0;
for (int i = 0; i < array.Length; i++)
    if (a == array[i])
        b++;

if (b > 0)
    Console.Write($"Данное число найдено {b} раз");
else
    Console.Write($"Данного числа нет");

/*for (int i = 0; i < array.Length; i++) - моё решение без ввода переменной 
{
    int a = 4;
    if (array[i] == a)
    {
        Console.Write($"; {a} -> yes");
        break;
    }
    else
    {
        Console.Write($"; {a} -> no");
        break;
    }

}
*/