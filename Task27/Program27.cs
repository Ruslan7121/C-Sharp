
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2,
                double y1, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

Console.Write("Длина отрезка: ");
Console.WriteLine(Decision(x1, x2, y1, y2));