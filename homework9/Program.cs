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

// Console.WriteLine($"From M = {M} before N = {N} -> sum of natural elements = {FindSum(M, N)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int FunctionAkkermana(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return FunctionAkkermana(m - 1, 1);
//     else return FunctionAkkermana(m - 1, FunctionAkkermana(m, n - 1));
// }

// Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"m = {m}, n = {n} -> Ackerman using recursion A(m,n) = {FunctionAkkermana(m, n)}");