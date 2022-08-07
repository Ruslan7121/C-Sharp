int[] list = new int[5];
string result = String.Empty;

for (int i = 0; i < list.Length; i++)
{
    list[i] = new Random().Next(1, 15);
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}; ");
        position++;
    }
}

PrintArray(list);
Console.WriteLine();
for (int i = 0; i < list.Length / 2; i++)
{
    result += $"{list[i] * list[list.Length - i - 1]}, ";
}
if (list.Length % 2 != 0) result += $"{list[list.Length / 2]}";

Console.WriteLine(result);