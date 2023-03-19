// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.Write("Enter the number of array elements: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int[M];

// void mas(int M)
// {
// for (int i = 0; i < M; i++)
// {
// Console.Write($"Enter {i+1} array element: ");
// Array[i] = Convert.ToInt32(Console.ReadLine());
// }
// }

// int kol(int[] Array)
// {
// int i=0;
// int sum = 0;
// while (i < Array.Length)
// {
// if(Array[i]>0)
// sum = sum + 1;
// i = i + 1;
// }
// return sum;
// }

// mas(M);
// Console.Write($"Numbers greater than zero: {kol(Array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("Enter a number b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"Two lines intersect at a point with coordinates: X: {x}, Y: {y}");