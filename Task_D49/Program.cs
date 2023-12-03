// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int m = Promt("Введите колличество строк - ");
int n = Promt("Введите колличество столбцов - ");
GetMatrix(m,n);

int Promt(string messege)
   {
    Console.Write(messege);
    int number = int.Parse(Console.ReadLine()!);
    return number;
   }

void GetMatrix(int row, int col)
   {
    double[,] array = new double[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble()*10 - 5;
            array[i,j] = Math.Round(array[i,j], 1);
            Console.Write($"{array[i,j]} || ");
        }
        Console.WriteLine();
    }
   }