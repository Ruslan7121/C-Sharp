Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] massive = new int[size];
int count = 0;
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(100, 999);
    if (massive[i] % 2 == 0)
    {
        count++;
    }
}

void PrintArray(int[] col)
{
    Console.Write("[");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.Write("]");
}

PrintArray(massive);
Console.WriteLine();
Console.WriteLine($"Четных чисел: {count}");