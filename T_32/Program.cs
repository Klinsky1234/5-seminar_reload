/* 32. Напишите прогу с заменой элементов массива,
 в которой положительные заменяться на отрицательные и наоборот*/
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++) // ниже моё решение с переменной f 
{
    int f = 0;
    f = array[i] * (-1);
    Console.Write($"{f} ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++) // ниже решение с семинара 
{
    array[i] *= -1;
    Console.Write($"{array[i]} ");
}