﻿Console.Write("Введите коллиечество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

FillArray(array);
PrintArray(array);

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) array[i, j] = array[i, j] * array[i, j];
        }
    }
}
Console.WriteLine(); 
ChangeArray(array);
PrintArray(array);