Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] factor(int N)
{

    int[] myArray = new int[N];
    int F = 1;
    for (int i = 1; i <= N; i++)
    {
        F = F * i;
        myArray[i - 1] = F;
    }
    return myArray;
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

PrintArray(factor(N));