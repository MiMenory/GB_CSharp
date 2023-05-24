using static System.Console;
Clear();

// Sqrt -- квадратный корень из числа, Pow -- это возведение в степень, 
//Sqrt --- частный случай Pow. Pow(4,1/2)==Sqrt(4)


// Теория

/*
string name = "Bob";
int age = 35;

// способы вывода

WriteLine("name: " + name + " age: " + age);
WriteLine($"Name: {name}, Age: {age}");
WriteLine("Name {0}, Age {1}", name, age);

string name1 = name + "111" + "!!!";
WriteLine(name1);

string name2 = string.Concat("111", name, "!!!");
WriteLine(name2);
*/


// Практика


// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// 4 = 1+2+3+4 

// Random rnd = new Random();
// int a = rnd.Next(4,5);
// int a1 = 1;
// Write(a);

// while(a > 1)
// {
//     a1 = a1 + a;
//     WriteLine($" '{a1}' ");
//     a--;
// }
// WriteLine($" {a1}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Write("Введите число: ");
// int a = Convert.ToInt32(ReadLine()!);
// int a1 = 0;
// int a2 = a;
// while(a > 0)
// {
//     a = a/10;
//     a1++;
// }
// WriteLine($"Кол-во цифр в числе {a2} = {a1}");



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Write("Введите цифру: ");
// int a = Convert.ToInt32(ReadLine()!);
// int a1 = 1;
// for (int i = 1; i < a+1; i++)
// {
//     a1 = a1 * i;
//     WriteLine($"{a1}");
// }



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Random rnd = new Random();
// int[] a = new int[8];
// Write("[");
// for (int i = 0; i < a.Length; i++)
// {
//     a[i] = rnd.Next(0,2);
//     Write($"{a[i]},");
// }
// Write("]");





