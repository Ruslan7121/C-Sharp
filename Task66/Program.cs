int N = InputInt("Введите число: ");
int FiniteNumber = 1;

if (N < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(NaturalNumber(N, FiniteNumber));

int NaturalNumber(int N, int FiniteNumber)
{
    if (N == FiniteNumber) return N;
    else
        Console.Write($"{NaturalNumber(N, FiniteNumber + 1)}, ");
    return FiniteNumber;
}

int InputInt(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}