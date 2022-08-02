Console.Write("Введите число: ");
int s = Convert.ToInt32(Console.ReadLine());
int num (int s)
    {
    int count = 0;
    if (s == 0) count = 1;
    while(s != 0)

        {
            s = s / 10;
            count = count + 1;
            
        }
    return count; 
    }       
Console.Write($"Цифр в числе: {num(s)}");