//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.
int M = InputInt("Введите первое натуральное число: ");
int N = InputInt("Введите второе натуральное число: ");
Console.WriteLine($"A({M}, {N}) = {AckermannFunction(M, N)}");

int AckermannFunction(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return AckermannFunction(M - 1, 1);
    else return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
} 

int InputInt(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}