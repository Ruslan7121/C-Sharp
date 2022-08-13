void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
void Main(string[] args)
{
    Console.Write("Введите размерность массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    int y = 0;
    bool z = false;
    bool zold = false;
    Console.Write("[ ");
    for (int i = 0; i < n; i++)

    {
        array[i] = new Random().Next(0, 124);
        zold = z;
        if (array[i] > 9 && array[i] < 100) z = true;
        else z = false;
        if (zold == false && z == true) y = y + 1;
        else zold = true;
    }

    PrintArray(array);
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine("Количество отрезков в массиве которые лежат в отрезке [10, 99 ]: " + y);
}
Main(args);