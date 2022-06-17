﻿// Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. 
// Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. 
// Определить размер депозита через n месяцев.

Console.Clear();
Console.WriteLine("***************************************************");
Console.WriteLine("****Программа рассчета депозита через N месяцев****");
double dep = 1000;

Console.WriteLine($"Сумма депозита на начало равна {dep}");
Console.WriteLine("Введите количество месяцев:");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int count = 1;

while (count <= N)
{
    dep = dep + dep * 0.015;
    count++;
}

Console.WriteLine($"Сумма депозита через {N} месяцев составит {Convert.ToInt32(dep)}");
Console.WriteLine("***************************************************");