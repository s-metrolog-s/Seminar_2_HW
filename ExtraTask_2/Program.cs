// Задача 2. На вход подаются год, номер месяца и день рождения человека.
// Определить возраст человека на момент 1 июля 2022 года.

Console.Clear();
Console.WriteLine("*********************************************************");

Random rand = new Random();
int day = rand.Next(1, 32);
int month = rand.Next(1, 13);
int year = rand.Next(1980, 2022);
string [] nameMonths = {"января", "февраля", "марта", 
                    "апреля", "марта", "июня", 
                    "июля", "августа", "сентября", 
                    "октября", "ноября", "декабря"};

Console.WriteLine($"Случайный день рождения человека {day} {nameMonths[month-1]} {year}");
Console.WriteLine("Рассчитываем возраст на 01 июля 2022");

int age = 2022 - year;
if (month < 7)
{
    Console.WriteLine($"Возраст человека составляет {age} года/лет");
}
else if (month > 7)
{
    Console.WriteLine($"Возраст человека составляет {age - 1} года/лет");
}
else if (month == 7)
{
    if (day == 1)
    {
        Console.WriteLine($"Возраст человека составляет {age} года/лет, с днем рождения!");
    }
    else
    {
        Console.WriteLine($"Возраст человека составляет {age - 1} года/лет");
    }
}

Console.WriteLine("*********************************************************");