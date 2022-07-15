Console.Write("Введи трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(x);
if (Number.Length > 2)
{
  Console.WriteLine("Третья цифра: " + Number[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет!");
}