int m = InputNumbers("Введите число строк двух матриц: ");
int n = InputNumbers("Введите число столбцов двух матриц: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
FillArray(firstMartrix);
Console.WriteLine($"\nМатрица №1:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[m, n];
FillArray(secomdMartrix);
Console.WriteLine($"\nМатрица №2:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m, n];

MultiplicationMatr(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение матриц:");
PrintArray(resultMatrix);

void MultiplicationMatr(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input) //присваиваем переменной InputNumbers значения m, n и range
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("|");
        Console.WriteLine("");
    }
}
