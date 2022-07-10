Console.WriteLine("Делится ли число на 2?");
Console.WriteLine();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if(x % 2 == 0)
{
    Console.Write("Да");
}
else 
{
    Console.Write("Нет");
}