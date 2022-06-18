// Задача 4. Дано натуральное число, в котором все цифры различны. 
// Определить, какая цифра расположена в нем левее: максимальная или минимальная.

Console.Clear();
Console.WriteLine("*******************************************************");
Console.Write("Дано число: ");

//Random rand = new Random(); Для тестирования разных значений
int N = 82317; // rand.Next(10, 50000);
Console.WriteLine(N);
Console.WriteLine("Проверяем положение максимального и минимального числа");

int number = N;
int count = 0;

while (number > 0) // Проверяем количество цифр в числе
{
    number = number / 10;
    count++;
}

int[] array = new int[count]; // Заполняем массив числом
int length = array.Length;
int index = 0;
int value  = N;

while (index < length)
{
    array[length -  1 - index] = value % 10;
    //Console.Write($"{array[length - 1 - index]} "); //Для проверки заполнения массива
    value = value / 10;
    index++;
}

index = 0;
int min = array[0];
int max = array[0];
int maxIdx = 0;
int minIdx = 0;


while (index < length) //Сравнием индексы максимального и минимального чисел
{
    if (array[index] > max) 
    {
        maxIdx = index;
        max = array[index];
    }
    if (array[index] < min) 
    {
        minIdx = index;
        min = array[index];
    }
    index++;
}

if (maxIdx > minIdx)
{
    Console.WriteLine("Минимальное число находится левее максимального");
}
else
{
    Console.WriteLine("Максимальное число находится левее минимального");
}

// Console.WriteLine($"{max} {min} {maxIdx} {minIdx}"); //Контроль нахождения чисел
Console.WriteLine("*******************************************************");