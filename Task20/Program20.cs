Console.Write("Введи цифру, обозначающую день недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int Number) {
  if (Number == 6 | Number == 7)   // | - опреатор "или"
  {
  Console.WriteLine("Это выходной день!");
  }

  else 
  if (Number < 1 | Number > 7) 
  {
    Console.WriteLine("Это не день недели!");
  }
  else Console.WriteLine("Это не выходной день!");
}

CheckingTheDayOfTheWeek(Number);