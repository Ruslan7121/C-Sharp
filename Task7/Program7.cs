//Console.SetCursorPosition(10, 4); - Команда что будет "рисовать". Отступ от левого края 10, отступ от правого 4 
//Console.Write("+");
 
Console.Clear(); // Оператор для очистки терминала 
int xa = 1, ya = 1;
 
// Определим 2 вершинe треугольника 
int xb = 30, yb = 30;
 
// Определим 3 вершинe треугольника 
int xc = 60, yc = 1;
 
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; // Определим случайную точку 

int count = 0; // Установим счетчик, который будет опредялять кол-во отрезков и деление пополам

while(count <1000) // Пока счетчик < 50
{
  int what = new Random().Next(0, 3); // Сгенирировать случайное число 0 1 2, будем выбирать одну из трех точек
  if(what == 0)
  {
    x = (x + xa) / 2;
    y = (y + ya) / 2;
  }
 
 if(what == 1)
  {
    x = (x + xb) / 2;
    y = (y + yb) / 2;
  }

  if(what == 2)
  {
    x = (x + xc) / 2;
    y = (y + yc) / 2;
  }
  
  Console.SetCursorPosition(x, y);
  Console.WriteLine("+");
  count = count + 1; // Счетчик будет увеличиваться на 1, пример записи: count +=1; count++;  
}