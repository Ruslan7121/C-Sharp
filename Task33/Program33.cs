Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число степени: ");
int b = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = a * result;
    }
    return result;
}
int exponentiation = Exponentiation(a, b);
Console.Write($"Ответ: {exponentiation}");