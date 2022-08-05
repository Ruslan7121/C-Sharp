/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/
Console.Write("Введите колличество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];
Console.WriteLine();
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
Console.WriteLine();
Console.WriteLine($"\nСумма положительных элементов: {sumP}");
Console.WriteLine($"Сумма отрицательных элементов: {sumN}");