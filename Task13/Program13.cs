Console.WriteLine("Какое из двух чисел больше?");
Console.WriteLine();
Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
if(x > y)
{
    Console.Write("max = " );
    Console.Write(x);
}
else 
{
    Console.Write("max = ");
    Console.Write(y);
}