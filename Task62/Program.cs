Console.Write("Введите количество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArray(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения:");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int m = 0; m < numbers.GetLength(1) - 1; m++)
        {
            if (numbers[i, m] > numbers[i, m + 1])
            {
                int оrdering = 0;
                оrdering = numbers[i, m];
                numbers[i, m] = numbers[i, m + 1];
                numbers[i, m + 1] = оrdering;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Массив с упорядоченными по возрастанию значениями в строках:");
PrintArray(numbers);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}