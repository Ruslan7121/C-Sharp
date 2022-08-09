Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] massive = new int[size];
int sum = 0;
int count = 0;

for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(0, 5);
    if (i % 2 != 0)
    {
        sum = sum + massive[i];
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
Console.WriteLine($"\nСумма элементов на нечётных позициях: {sum}");