﻿using static System.Console;
Clear();


 // Sqrt -- квадратный корень из числа, Pow -- это возведение в степень, Sqrt --- частный случай Pow. Pow(4,1/2)==Sqrt(4)


// Массив

// Объявление массива = int[] 
// int[] array = new int[4] // создали массив на 4 элемента.
// int[] array = {1,2,3,4} // можно сразу указать размерность
// string[] array = {"Moscow", "Spb", "Sochi"} = Строки

// int[] array = {1,2,3,4};
// WriteLine($"{array[array.Length-1]}");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * 2;
//     Write($"{array[i]},");
// }


// ************ Задачи ************


// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Write("Введите координату X: ");
int x = Convert.ToInt32(ReadLine()!);
Write("Введите координату Y: ");
int y = Convert.ToInt32(ReadLine()!);


if (x > 1 & y > 1)
{
    Write("Номер чертверти: 1");
}
if (x > 1 & y < 0)
{
    Write("Номер четверти: 2");
}
if (x < 0 & y < 0)
{
    Write("Номер четверти: 3");
}
if (x < 0 & y > 0)
{
    Write("Номер четверти: 4");
}



// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)


Write("Введите номер четверти: ");
int x = Convert.ToInt32(ReadLine()!);

if (x == 1)
{
    Write("x > 0 and y > 0");
}


// Задача 21: Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Write("Введите координату точки a1: ");
int a1 = Convert.ToInt32(ReadLine()!);
Write("Введите координату точки a2: ");
int a2 = Convert.ToInt32(ReadLine()!);

Write("Введите координату точки b2: ");
int b1 = Convert.ToInt32(ReadLine()!);
Write("Введите координату точки b2: ");
int b2 = Convert.ToInt32(ReadLine()!);

double total = Math.Sqrt(Math.Pow(a1 - b1,2) + Math.Pow(a2 - b2,2));
Write($"{Math.Round(total,3)}");



// Задача 22: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int[] array = {1,3,4,5,6,7};
WriteLine($"Длинная массива = {array[array.Length-1]}");
for (int i = 1; i < array.Length; i++)
{
    Write($"{Math.Pow(i,2)}, ");
}


