Console.Write("Введите X: ");
int xx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X: ");
int yy = Convert.ToInt32(Console.ReadLine());
string check_xy(int x, int y)
{
    if (x > 0 && y > 0) return ("Первая четверть");
    else if (x < 0 && y > 0) return ("Вторая четверть");
    else if (x < 0 && y < 0) return ("Третья четверть");
    else if (x > 0 && y < 0) return ("Четвертая четверть");
    else return ("Какая-то из координат равна нулю");
}
Console.WriteLine(check_xy(xx, yy));