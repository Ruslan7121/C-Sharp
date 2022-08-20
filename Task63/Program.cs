Console.Write("Введите коллиечество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
Console.WriteLine();

FillArray(numbers);
PrintArray(numbers);
int minsum = Int32.MaxValue;
int IndexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        IndexLine++;
    }
}

Console.WriteLine("\nСтрока с наименьшей суммой элементов №" + (IndexLine) + ". Сумма элементов в ней равна " + (minsum) + ".");

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");

        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 6);
        }
    }
}