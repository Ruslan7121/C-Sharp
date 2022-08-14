Console.WriteLine("\nНайти точку пересечение двух прямых, заданных уравнениями: \ny = k1 * x + b1 \ny = k2 * x + b2");
double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
    for (int i = 0; i < coeff.GetLength(0); i++) // coeff.GetLength(0) - возвращает количество строк в матрице
    {
        Console.WriteLine($"\nВведите коэффициенты {i + 1}-го уравнения (y = k * x + b):");
        for (int j = 0; j < coeff.GetLength(1); j++) // coeff.GetLength(1) - возвращает количество столбцов
        {
            if (j == 0) Console.Write($"Коэффициент k равен: ");
            else Console.Write($"Коэффициент b равен: ");
            coeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] coeff)
{
    crossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    crossPoint[1] = crossPoint[0] * coeff[0, 0] + coeff[0, 1];
    return crossPoint;
}

void OutputResponse(double[,] coeff)
{
    if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
    {
        Console.Write($"\nПрямые совпадают");
    }
    else if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
    {
        Console.Write($"\nПрямые параллельны");
    }
    else
    {
        Decision(coeff);
        Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputCoefficients();
OutputResponse(coeff);