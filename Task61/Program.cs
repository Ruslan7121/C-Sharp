using System;
using System.Collections.Generic;

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
            matr[i,j] = new Random().Next(0, 10);
        }
      }
    }

    static void FindElement(int t, int[,] matr, List<int> numsList )
    {
      int count=0;
      for (int i = 0; i < matr.GetLength(0); i++)
      {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (t==matr[i,j]) 
            {
              count++;
            }
        }
      }
        numsList.Add(t);
       Console.WriteLine($"Число {t} встречается {count} раз ");
    }
  
    static void Main(string[] args)
    {  
        
        Console.Write("Введите кол-во строк массива: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите кол-во столбцов массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int [,] array = new int[m,n];
        FillArray (array);
        Console.WriteLine("Заданный массив: ");
        PrintArray(array);
        Console.WriteLine("");
        List<int> numsList = new List<int>();
        for (int i = 0; i < m; i++)
        {
        for (int j = 0; j < n; j++)
          {
            if (numsList.Contains(array[i,j])==false)
            FindElement(array[i,j],array, numsList);

          }
        }
        
    }
}
