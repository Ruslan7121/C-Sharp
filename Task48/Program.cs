Console.Write("Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());

string res = string.Empty;

while(num > 0)
{
    res = (num % 2) + res;
    num = num/2;
}

Console.WriteLine($"Двоичное число: {res}");