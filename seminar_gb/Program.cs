using static System.Console;
Clear();

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Вариант решения через строку

// Write("Введите 5-ти значное число: ");
// string a = Convert.ToString(ReadLine()!);

// if (a.Length > 5 || a.Length < 5)
// {
//     WriteLine("Число не равно 5 цифрам");
// }
// if (a[0] == a [4])
// {
//     if (a[1] == a[3])
//     {
//         WriteLine("Число полиндром");
//     }
// }
// else
// {
//     WriteLine("Не полиндром");
// }

// Вариант решения через цифры

// Write("Введите 5-ит значное число: ");
// int b = Convert.ToInt32(ReadLine()!);
// int b5 = b%10; // забрали 5ое число
// int b4 = b%100/10; // забрали 4ое число
// int b3 = b/100%10; // забрали 3е число
// int b2 = b/10/100%10; // забрали 2ое число


// WriteLine($"{b5} {b4} {b3} {b2}");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Write("Координата X: ");
// int x = Convert.ToInt32(ReadLine()!);
// Write("Координата Y: ");
// int y = Convert.ToInt32(ReadLine()!);
// Write("Координата Z: ");
// int z = Convert.ToInt32(ReadLine()!);

// Write("Координата X1: ");
// int x1 = Convert.ToInt32(ReadLine()!);
// Write("Координата Y1: ");
// int y1 = Convert.ToInt32(ReadLine()!);
// Write("Координата Z1: ");
// int z1 = Convert.ToInt32(ReadLine()!);

// double total = Math.Sqrt(Math.Pow(x - x1,2) + Math.Pow(y - y1,2) + Math.Pow(z - z1,2));
// WriteLine(Math.Round(total,2));



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Write("Введите число, мы возведем в куб: ");
// int a = Convert.ToInt32(ReadLine()!);

// for (int i = 0; i < a+1; i++)
// {
//     Write($"{Math.Pow(i,3)} ");
// }