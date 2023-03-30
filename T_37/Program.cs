/* 37. Найдите произведение пар чисел в одномерном массиве.
Пара: первое и последее число, второе и предпоследнее.
Результат запишите в новом массиве*/
int[] array = new int[5];
/* int len2 = 0;
if (array.Length % 2 == 0) len2 = array.Length / 2; если len2 делится на 2 без остатка  
else len2 = array.Length / 2 + 1;*/
int[] array2 = new int[array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1]; // тернарный оператор 
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array[i] * array[array.Length - i - 1];
    {
        if (i == array.Length - i - 1)
            array2[i] = array[i];
    }
    Console.Write($"{array2[i]} ");
}