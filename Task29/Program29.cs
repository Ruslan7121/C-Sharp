Console.Write("Введине число: ");
int x = Convert.ToInt32(Console.ReadLine());

int summ = 0;

for (int i = 1; i <= x; i++)
{
    summ = summ + i;
}
Console.WriteLine($"Сумма чисел: {summ}");