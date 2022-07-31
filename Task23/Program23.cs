Console.Write("Введите число: ");
int aa = Convert.ToInt32(Console.ReadLine());
void Coub(int a)
{
    for (int i = 1; i <= a; i++)
    {
        Console.Write(i * i * i + " ");
    }
}
Coub(aa);