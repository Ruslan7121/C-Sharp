Console.WriteLine("Какие есть четные числа до заданного начиная от 1?");
Console.WriteLine();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = 1;
Console.WriteLine(y);
while (y <= x)
{
    
    if(y % 2 == 0)
    Console.WriteLine(y);
    y += 1;
}