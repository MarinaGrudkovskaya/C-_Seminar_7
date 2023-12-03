// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.
int row = Promt("Введите количество строк - ");
int col = Promt("Введите количество столбцов - ");
int[,] array = GetArray(row, col);
Console.WriteLine();
SummerString(array);

int Promt(string messege)
   {
    Console.Write(messege);
    int number = int.Parse(Console.ReadLine()!);
    return number;
   }
int[,] GetArray(int row, int colon)
   {
    int[,] arr = new int[row, colon];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1,10);
            Console.Write($"{arr[i,j]} ");
        } 
        Console.WriteLine();
    }
    return arr;
   }

void SummerString(int[,] matrix)
   {
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i,j];
        }
        sum = Math.Round(sum/matrix.GetLength(0), 2);
        Console.Write($"{sum}  ");
    }
   }