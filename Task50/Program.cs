Console.Write($"Введите количествово элементов массива: ");
int arrayDimensions = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[arrayDimensions];

void InputNumbers(int arrayDimensions)
{
    for (int i = 0; i < arrayDimensions; i++)
    {
        Console.Write($"Введи значение {i + 1} индекса массива: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int findingPositive(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0)
        count++;
    }
    return count;
}

InputNumbers(arrayDimensions);

Console.WriteLine($"Количествово элементов больше нуля: {findingPositive(massiveNumbers)} ");