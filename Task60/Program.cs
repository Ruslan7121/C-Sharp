Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];



void PrintMatrix(int[,] matrix)
{                                  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 50);
        }
    }
}

void TransP (int[,] matrix, int[,] array_2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array_2[i, j] = matrix[j, i];
        }
    }
}


FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
int[,] array_2 = new int[n, m];
try
{
    TransP(array, array_2);
    PrintMatrix(array_2);
}
catch
{
    Console.WriteLine("Размерность матрицы должна быть одинаковой");
}

