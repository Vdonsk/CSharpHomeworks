// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             myArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] DescendingArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.Write("Input the number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal values: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximum values: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Show2DArray(myArray);
// myArray = DescendingArray(myArray);
// Show2DArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             myArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] SumRows(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Array is not rectangular");
//         return null;
//     }
//     else
//     {
//         int[] arraySumRows = new int[array.GetLength(0)];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 arraySumRows[i] = arraySumRows[j] + array[i, j];
//             }
//         }
//         return arraySumRows;
//     }
// }

// void SmalleSumRows(int[] array)
// {
//     int minSumRows = array[0];
//     int minRows = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < minSumRows)
//         {
//             minSumRows = array[i];
//             minRows = i;
//         }
//     }
//     Console.WriteLine($"Row number with the smallest sum of elements: {minRows + 1}");
// }

// Console.Write("Input the number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal values: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximum values: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Show2DArray(myArray);
// int[] arraySumRows = SumRows(myArray);
// SmalleSumRows(arraySumRows);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] Create3DRandomArray(int x, int y, int z, int minValue, int maxValue)
// {
//     int[,,] myArray = new int[x, y, z];
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {
//             for (int k = 0; k < z; k++)
//             {
//                 myArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     }
//     return myArray;
// }

// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.WriteLine($"{array[i, j, k]} ({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input the number of x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal values: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximum values: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(x, y, z, minValue, maxValue);
// Show3DArray(myArray);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Write("Input size of array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}