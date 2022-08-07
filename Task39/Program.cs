Console.Write("Введите число: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];
int sumN = 0;
int sumP = 0;

for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(-9, 10);

    if (massive[i] > 0)
    {
        sumP = sumP + massive[i];
    }

    else sumN = sumN + massive[i];


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
for (int i = 0; i < massive.Length; i++) massive[i] *= - 1;

Console.WriteLine();
PrintArray(massive);

