int M = InputInt("Введите первое натуральное число: ");
int N = InputInt("Введите второе натуральное число: ");
Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна: {SumOfNaturalNumbers(M, N)}");

int SumOfNaturalNumbers(int M, int N)
{
    if (M == N) return N;
    return N + SumOfNaturalNumbers(M, N - 1);
}

int InputInt(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}