// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5;  b = 7  -> max = 7
// a = 2;  b = 10 -> max = 10
// a = -9; b = -3 -> max = -3


// int max = 0;
// int min = 0;

// Console.Write("a: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b)
// {
//     max = a;
//     min = b;
// }
// else
// {
//     max = b;
//     min = a;
// }
// Console.WriteLine("max number ->" + max); 
// Console.WriteLine("min number ->" + min);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// int max = 0;
// Console.Write("first number: ");
// int first = Convert.ToInt32(Console.ReadLine());

// Console.Write("second number: ");
// int second = Convert.ToInt32(Console.ReadLine());

// Console.Write("third number: ");
// int third = Convert.ToInt32(Console.ReadLine());

// if (second > first)
// {
//     max = second;

// if (third > second)
// {
//     max = third;
// }
// else
// {
//     max = second;
// }
// }
// else
// {
//     max = first;
// if (third > first)
// {
//     max = third;
// }
// else
// {
//     max = first;
// }
// }
// Console.WriteLine("max number ->" + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("number: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int number = N % 2;

// if(number == 0)
// {
//     Console.WriteLine("even");
// }
// else
// {
//     Console.WriteLine("not even");
// }