Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] factor(int a)
{

    int[] myArray = new int[a];
    int b = 1;
    for (int i = 1; i <= a; i++)
    {
        b = b * i;
        myArray[i - 1] = b;
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
PrintArray(factor(a));