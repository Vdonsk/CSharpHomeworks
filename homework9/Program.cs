// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void ShowNumbers(int N)
// {
//     if (N >= 1)
//     {
//         Console.Write(N + ", ");
//         ShowNumbers(N - 1);
//     }
// }
// ShowNumbers(8);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSum(int M, int N)
// {
//     if (M != N)
//     {
//         if (M <= N)
//         {
//             return FindSum(M + 1, N) + M;
//         }
//         else
//         {
//             return FindSum(M, N + 1) + N;
//         }
//     }
//     else return M;
// }

// Console.Write("Input M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"From M = {M} before N = {N} sum of natural elements = {FindSum(M, N)}");