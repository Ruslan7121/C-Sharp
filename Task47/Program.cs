int a = Coordinate("a");
int b = Coordinate("b");
int c = Coordinate("c");

int Coordinate(string coorName)
{
    Console.Write($"Введите координату {coorName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

if (a < (b + c) && b < (a + c) && c < (a + b)) Console.WriteLine("Да, это треугольник!");
else Console.WriteLine("Нет, это не треугольник!");