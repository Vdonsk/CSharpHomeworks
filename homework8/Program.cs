﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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