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

Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] massive = new int[size];

for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(0, 5);
}

PrintArray(massive);
Console.WriteLine();
int count = size / 2;
int bath = 0;
for (int i = 0; i < count; i++)
{
    bath = massive[i];
    massive[i] = massive[size - 1 - i];
    massive[size - 1 - i] = bath;
}

PrintArray(massive);