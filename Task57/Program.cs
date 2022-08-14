Console.Write("Перевд вами массив 5х5. Для поиска нужного занчения:\n");
Console.Write("ведите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("ведите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[5, 5];
Console.WriteLine();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такой элемент отсутствует");
}
else
{
    Console.WriteLine($"\nВ строке {n} строки, в столбце {m} находится значение {numbers[n - 1, m - 1]}");
}