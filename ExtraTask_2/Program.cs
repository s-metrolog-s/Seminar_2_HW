// Задача 2. На вход подаются год, номер месяца и день рождения человека.
// Определить возраст человека на момент 1 июля 2022 года.

Console.WriteLine("Введите день, месяц и год рождения в формате dd:mm:yyyy:");

int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 && day > 31)
{
    day = Convert.ToInt32(Console.ReadLine());
}

int month = Convert.ToInt32(Console.ReadLine());
int year = Convert.ToInt32(Console.ReadLine());



Console.WriteLine($"{day}:{month}:{year}");