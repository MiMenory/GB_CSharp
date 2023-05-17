using static System.Console;
Clear();

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Write("Введите исло 1: ");
int num1 = Convert.ToInt32(ReadLine()!);
Write("Введите исло 2: ");
int num2 = Convert.ToInt32(ReadLine()!);

if (num1 > num2)
{
    WriteLine($"{num1} > {num2} ");
}
else
{
    WriteLine($"{num2} > {num1} ");
}



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Write("Введите исло 1: ");
int num1 = Convert.ToInt32(ReadLine()!);
Write("Введите исло 2: ");
int num2 = Convert.ToInt32(ReadLine()!);
Write("Введите исло 3: ");
int num3 = Convert.ToInt32(ReadLine()!);

if (num1 > num2 & num1 > num3)
{
    WriteLine($"{num1} > {num2} and {num3}");
}
if (num2 > num1 & num2 > num3)
{
    WriteLine($"{num2} > {num1} and {num3}");
}
if (num3 > num1 & num3 > num2)
{
    WriteLine($"{num3} > {num1} and {num2}");
}


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine()!);

if (num1 % 2 == 0)
{
    WriteLine($"Число {num1} четное");
}
else
{
    WriteLine($"Число {num1} не четное");
}




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Write("Число: ");
int num1 = Convert.ToInt32(ReadLine()!);
int num2 = 1;

for (int i = num1; num2 < i; num2++)
{
    if (num2 % 2 == 0)
    {
        Write($"{num2}, ");
    }
}
