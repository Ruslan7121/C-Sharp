Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
}

double max = Int32.MaxValue; //MaxValue используется для представления максимального значения Int32.
double min = Int32.MinValue; //MinValue используется для представления минимального значения Int32.

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > max)
    {
        max = numbers[j];
    }
    if (numbers[j] < min)
    {
        min = numbers[j];
    }
}


void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}

PrintArray(numbers);
Console.WriteLine("\n");
Console.WriteLine($"Максимальное значение = {max} \nМинимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");