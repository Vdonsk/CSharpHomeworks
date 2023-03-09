// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Write("Enter а FiveDigit number -> ");
// string number = Console.ReadLine();

// if (number.Length == 5)
// {
//     ChekingNumber(number);
// }
// else Console.WriteLine($"You entered a non FiveDigit number");

// void ChekingNumber(string number)
// {
//     if (number[0] == number[4] || number[1] == number[3])
//     {
//         Console.WriteLine($"Your number -> {number} -> palindrome");
//     }
//     else Console.WriteLine($"Your number -> {number} -> not a palindrome");
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// int x1 = Coordinate("x1 -> ");
// int y1 = Coordinate("y1 -> ");
// int z1 = Coordinate("z1 -> ");
// int x2 = Coordinate("x2 -> ");
// int y2 = Coordinate("y2 -> ");
// int z2 = Coordinate("z2 -> ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z2 - z1;

// double Length = Math.Sqrt(A * A + B * B + C * C);
// int Coordinate(string massage)

// {
//     Console.WriteLine(massage);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("Distance = " + Length);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// int number = cube("Enter number -> ");

// for (int i = 1; i <= number; i++)
// {
//     Console.WriteLine($"{i * i * i}");
// }

// int cube(string massage)
// {
//     Console.WriteLine(massage);
//     return Convert.ToInt32(Console.ReadLine());
// }