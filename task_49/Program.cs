// Общее обсуждение
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
int[,] arr = GetMatrix(3,4);
Console.WriteLine();
int[,] arr1 = IndexChetniy(arr);

int[,] GetMatrix(int row, int column)
   {
    int[,]array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
   }

int[,] IndexChetniy(int[,] array)
   {
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if(i%2==0 && j%2==0)
            array[i,j] = array[i,j]*array[i,j];
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
   }