
// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
int[,] array = GetMatrix(4,4);
Console.WriteLine();
GetSummer(array);

int[,] GetMatrix(int row, int column)
   {
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = new Random().Next(1,10);
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    return arr;
   }

void GetSummer(int[,] array)
   {
    int summer = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == i)
            summer = summer + array[i,j];
        }
    }
    Console.Write($"= {summer}");
   }