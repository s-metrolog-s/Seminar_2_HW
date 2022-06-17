// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("****************************************");
Console.WriteLine("Введите произвольное число:");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (N / 100 == 0) // Проверяем наличие третьего числа
{
    Console.WriteLine($"У числа {N} нет третьей цифры");
}
else
{
    int count = 0; 
    int number = N;
    while (number > 0) // Находим количество символов числа для заполнения массива
    {
        number = number / 10;
        count++;
    }

    int[] array = new int[count]; // Заполняем массив
    int length = array.Length;
    int index = 0;
    int del = N;

    while (index < length)
    {
        array[length - 1 - index] = del % 10;
        del = del / 10;
        index++;
    }  

Console.Write($"Третья цифра числа {N} - это {array[2]}");
Console.WriteLine();
}
Console.WriteLine("****************************************");
