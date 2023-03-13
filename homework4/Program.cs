// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int Exponentiation(int A, int B)
// {
//     int result = 1;
//     for (int i = 1; i <= B; i++)
//     {
//         result *= A;
//     }
//     return result;
// }

// Console.Write("Enter the number A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the number B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int exponentiation = Exponentiation(A, B);
// Console.WriteLine("Answer: " + exponentiation);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Enter the number A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// int Sum(int A)
// {
//     int counter = Convert.ToString(A).Length;
//     int promote = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++)
//     {
//         promote = A - A % 10;
//         result = result + (A - promote);
//         A = A / 10;
//     }
//     return result;
// }

// int sum = Sum(A);
// Console.WriteLine("Answer: " + sum);