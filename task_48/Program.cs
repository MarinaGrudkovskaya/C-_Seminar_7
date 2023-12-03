// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
int m = 3;
int n = 4;
int[,] arr = GetMatrix(m,n);
int[,] GetMatrix(int row, int column)
    {
        int[,] array = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                array[i,j] = i + j;
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
        return array;
    }
