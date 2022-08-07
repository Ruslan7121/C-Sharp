Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Какое число необходимо найти? ");
int x = Convert.ToInt32(Console.ReadLine());
bool y = false;
int[] massive = new int[size];
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(-9, 10);
    if (massive[i] == x) y = true;
}
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
PrintArray(massive);
Console.WriteLine();
if (y) Console.WriteLine("Такое число есть в массиве.");
else Console.WriteLine("Такого числа нет в массиве.");