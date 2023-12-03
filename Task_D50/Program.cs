// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] array = new int[,]
{
  {1, 4, 7, 2},
  {5, 9, 2, 3},
  {8, 4, 2, 4},
};
PrintMatrix(array);
int vaiue1 = GetNumbers("Введите значения i -> ");
int vaiue2 = GetNumbers("Введите значения j -> ");
PositionElement(array, vaiue1, vaiue2);
void PrintMatrix(int[,] arr)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
  }
int GetNumbers(string messege)
   {
    Console.Write(messege);
    int number = int.Parse(Console.ReadLine()!);
    return number;
   }

void PositionElement(int[,] array, int i, int j)
   {
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            if(k==i && l==j) 
            
            Console.Write(array[k,l]);
        } 
    }
             if(i > array.GetLength(0)-1 || j > array.GetLength(1)-1)
            Console.Write("-> такого числа в массиве нет"); 
   }

   