using static System.Console;
Clear();


/*
--- Варианты вывода на экран: ---
string name = "Bob";
int age = 35;
WriteLine("Имя: " + name + " Возраст: " + age);
WriteLine($"Имя: {name} возраст: {age}");
WriteLine("Имя: {0} возраст: {1}", name, age);
string name1 = "111" + "!!!" + name;
WriteLine(name1);
string name2 = string.Concat("111", name, "!!!");
WriteLine(name2);
--- Сравнение строк ---
string a = "abc";
string b = "abc";
сравниваем через if
*/


/* --- задачт -- */


// Задача 24: Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// Write("Введите число: ");
// int a = Convert.ToInt32(ReadLine()!);
// WriteLine(a);

// for (int i = 1; a > 1; a--)
// {
//     i = i + a;
//     Write($"{i} ");
// }

// Альтернативное решение

// int a = new Random().Next(3,10);
// WriteLine(a);
// int num = 1;

// while(a>1)
// {
//     num = num + a;
//     a--;
// }
// Write(num);


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Random rnd = new Random();
// int a = rnd.Next(100,9999);
// WriteLine(a);

// for (int i = 1; a > 0; i++)
// {
//     a = a/10;
//     Write(i);
// }

// альтернативное решение 


// int a = new Random().Next(100,1500);
// WriteLine(a);
// int num = 0;

// while(a>0)
// {
//     a = a/10;
//     num++;
// }
// WriteLine($"{num} ");



// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


// int a = new Random().Next(2,8);
// WriteLine(a);
// int num = 1;

// while(a>1)
// {
//     num = num * a;
//     a--;
// }
// Write(num);


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8];
// Write("[");
// for (int i = 0; i < array.Length; i++)
// {
//     int a = new Random().Next(0,2);
//     array[i] = array[a] + i;
//     Write($"{array[a]},");
// }
// Write("]");