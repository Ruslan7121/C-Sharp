Console.Write("Введи трёхзначное число: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeNumber);
Console.WriteLine("Вторая цифра этого числа: " + stringNumber[1]);