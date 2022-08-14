Console.Write("Введите коллиечество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
Random random = new Random();

Console.Write("\n");
for (int i = 1; i <= n; i++)
{
    Console.Write("    " + i + "  ");
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,7:F2}", array[i, j]);
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = random.NextDouble() * 10;
        }
    }
}
Console.Write("\n");
FillArray(array);
PrintArray(array);


Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
    double x = 0;
    for (int j = 0; j < m; j++)
    {
        x += array[j, i];
    }
    x = Math.Round(x / m, 2);   //2 - чисел после запятой
    Console.WriteLine($"cтолбца №{i + 1}: {x}");
}