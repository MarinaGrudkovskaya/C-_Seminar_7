// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int row = 3;
int col = 4;
int[,] newArray = GetArrayDvymernuy(row, col);
int[,] GetArrayDvymernuy(int m, int n)
   {
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        array[i,j] = new Random().Next(-10, 100);
        Console.Write($"{array[i,j]} ");
      }  
      Console.WriteLine();
    }
    return array;
   }
