
using System;

class Program
{
    static void PrintArray(int[,] matr)
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

    static void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(0, 10);
            }
        }
    }

    static void ChangeArray(int[,] matr)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int t = matr[0, j];
            matr[0, j] = matr[matr.GetLength(0) - 1, j];
            matr[matr.GetLength(0) - 1, j] = t;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите кол-во строк массива: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите кол-во столбцов массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[m, n];
        FillArray(array);
        Console.WriteLine("Заданный массив: ");
        PrintArray(array);
        ChangeArray(array);
        Console.WriteLine("Образованный массив: ");
        PrintArray(array);

    }
}