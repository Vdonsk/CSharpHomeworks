// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] myArray = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             myArray[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) / 10;
//         }
//     }
//     return myArray;
// }
// void Show2DArray(double[,] array)
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

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DRandomArray(rows, columns, minValue, maxValue));


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int m = 3;
// int n = 4;
// int[,] arr = new int[m, n];
// Console.WriteLine("Введите значение: ");
// int number = Convert.ToInt32(Console.ReadLine());
// FillArray(arr);
// FindElementArray(arr, number);

// void FillArray(int[,] arrayToFill)
// {
//     for (int i = 0; i < arrayToFill.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayToFill.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindElementArray(int[,] findelement, int usernamber)
// {
//     bool find = false;
//     for (int i = 0; i < findelement.GetLength(0); i++)
//     {
//         for (int j = 0; j < findelement.GetLength(1); j++)
//         {
//             if (findelement[i, j] == usernamber)
//                 Console.WriteLine($"Ваше значение находится по координатам {i} {j}");
//             find = true;
//         }
//     }
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.Write("Введите количество строк ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[n, m];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         avarage = (avarage + numbers[i, j]);
//     }
//     avarage = avarage / n;
//     Console.Write(avarage + " | ");
// }
// Console.WriteLine();


// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }