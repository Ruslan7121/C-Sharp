Console.Write("Введите колличество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];

for (int i = 0; i < massive.Length; i++)
massive[i] = new Random().Next(-10, 10);

Console.WriteLine("[{0}]", string.Join(", ", massive));
