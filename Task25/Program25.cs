Console.Write("Введите ночер четверти: ");
int xx = Convert.ToInt32(Console.ReadLine());
string check_x(int x)
{
    if (x == 1) return ("Первая четверть");
    else if (x == 2) return ("Вторая четверть");
    else if (x == 3) return ("Третья четверть");
    else if (x == 4) return ("Четвертая четверть");
    else return ("Такой четверти нет");
}
Console.WriteLine(check_x(xx));