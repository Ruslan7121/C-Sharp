Console.Write("Введите одинаковое коллиечество строк и столбцов\n");
Console.Write("Введите коллиечество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int sumD1 = 0;
int sumD2 = 0;
int[,] array = new int[m, n];

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
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void FindSumD1(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sumD1 = sumD1 + matr[i, j];
            if (i + j == m - 1) sumD2 += matr[i, j];
        }
    }
    Console.WriteLine("Сумма элементов по диагонали слева направо: " + sumD1);
    Console.WriteLine("Сумма элементов по диагонали справа налево: " + sumD2);
}

try
{
    Console.WriteLine();
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    FindSumD1(array);
}
catch
{
Console.Write("Надо ввести одинаковое коллиечество строк и столбцов!");
}