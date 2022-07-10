Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = -a;
while (b <= a)
	{
    Console.Write(b);
    b = b + 1;
}