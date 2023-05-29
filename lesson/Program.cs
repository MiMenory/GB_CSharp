using static System.Console;
Clear();

// Sqrt -- квадратный корень из числа, Pow -- это возведение в степень, Sqrt --- частный случай Pow. Pow(4,1/2)==Sqrt(4)

// Методы

/*
Ищем максимальное из 2-х чисел

int x = 3;
int y = 2;

if (x > y)
{
    Write("X > Y");
}

------------------------------------
X Y могу меняться время от времени. 


Отпимизация кода. МЕТОДЫ

1. Метод, который ничего не возвращает VOID
*/

// string a = "Bob";
// void HelloWorld(string name)
// {
//     Write($"Привет, {name}");
// }

// HelloWorld(a); // вызвали метод

// Random rnd = new Random();
// int x = rnd.Next(1,10);
// int y = rnd.Next(1,10);

// int xx = rnd.Next(1,10);
// int yy = rnd.Next(1,10);

// void maxNum(int qqq, int www) // не возвращаем данные
// {
//     if (qqq > www)
//     {
//         WriteLine("X > Y");
//     }
//     else
//     {
//         WriteLine("X < Y");
//     }
// }
// maxNum(x,y);
// maxNum(xx,yy);



// Вариант с возвратом каких то данных


// int MaxNum(int x, int y) // возврат значений
// {
//     if (x > y)
//     {
//         return x;
//     }
//     else
//     {
//         return y;
//     }
// }

// Random rnd = new Random();
// int x = rnd.Next(1,10);
// int y = rnd.Next(1,10);

// int xx = rnd.Next(1,10);
// int yy = rnd.Next(1,10);

// int mm = MaxNum(x,y);
// int mmm = MaxNum(xx,yy);

// WriteLine($"{mm} {mmm}");



// Задачи


// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

//Заполнение массива

// void FillArr(int[] array)
// {
//     Random rnd = new Random(); // создаем удобный формат рандомных чисел
//     int a = 0; // создаем переменную для работы цикла
//     while(a < array.Length) // запускаем цикл и проверяем, пока переменная А меньше длинны атрибута array. 
//     //Цикл повторяется
//     {
//         array[a] = rnd.Next(-9,10); // каждый раз при цикле будет генерироваться случайно число из диапазона
//         a++; //  и прибавляться значение в переменную А, пока она не станет равна длинне массива
//     }
// }

// //Вывод массива
// void PrintArr(int[] Narray)
// {
//     int count = Narray.Length;
//     int pos = 0;
//     while(pos < count)
//     {
//         Write($"{Narray[pos]},");
//         pos++;
//     }
// }

// // проверяем на положительные и отрицательные числа
// void summ (int[] array)
// {
//     int count = 0; // счетчик
//     int SumMin = 0; // тут будут сумма отрицательных чисел
//     int SumPlus = 0; //  тут сумма положительныех чисел
//     while(count < array.Length)
//     {
//         if(array[count] < 0)
//         {
//             SumMin += array[count];
//             count++;
//         }
//         else
//         {
//             SumPlus += array[count];
//             count++;
//         }
//     }
//     WriteLine($"Сумма отрц чисел {SumMin}");
//     WriteLine($"Сумма полж чисел {SumPlus}");
// }

// // вызвать

// int[]arr = new int[12];
// FillArr(arr); // заполнение массива
// PrintArr(arr); // печать массива
// Write("\n"); // перенос строки
// summ(arr); // сумма отр или пол. чисел


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// создаем массив
// void CreateArray(int[] array)
// {
//     Random rnd = new Random();
//     int count = 0;
//     while(count < array.Length)
//     {
//         Write($"{array[count] = rnd.Next(-9,9)},");
//         count++;
//     }
// }

// void reversArray(int[] revers)
// {
//     int count = 0;
//     int rev = 0;
//     while(count < revers.Length)
//     {
//         if (revers[count] < 0)
//         {
//             rev =+ Math.Abs(revers[count]);
//             count++;
//         }
//         else
//         {
//             rev =+ -revers[count];
//             count++;
//         }
//         Write($"{rev},");
//     } 
// }


// int[] arr = new int[3];
// CreateArray(arr);
// Write("\n");
// reversArray(arr);







// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует 
// ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



// создаем массив
// void CreateArray(int[] array)
// {
//     Random rnd = new Random();
//     int count = 0;
//     while(count < array.Length)
//     {
//         Write($"{array[count] = rnd.Next(1,9)},");
//         count++;
//     }
// }

// // ищем цифры
// void findarray(int[] find)
// {
//     int a = 0;
//     int con = 3;
//     while(a < find.Length)
//     {
//         if(find[a] == con)
//         {
//             WriteLine($"цифра {con} есть в массиве");
//             break;
//         }
//         else
//         {
//             //WriteLine("данной цифры нет");
//             a++;
//         }
//     }
// }


// int[] arr = new int[5];
// CreateArray(arr);
// Write("\n");
// findarray(arr);


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void CreateArray(int[] array)
// {
//     Random rnd = new Random();
//     int count = 0;
//     while(count < array.Length)
//     {
//         Write($"{array[count] = rnd.Next(1,123)},");
//         count++;
//     }
// }

// void finearray(int[] find)
// {
//     int a = 0;
//     int b = 0;
//     while(a < find.Length)
//     {
//         if(find[a] > 10 && find[a] < 100)
//         {
//             b++;
//         }
//         a++;
//     }
//     WriteLine($"Значений, который лежат в отрезке от 10 до 99: {b}");
// }


// int[] arr = new int[5];
// CreateArray(arr);
// Write("\n");
// finearray(arr);





// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// void CreateArray(int[] array)
// {
//     Random rnd = new Random();
//     int count = 0;
//     while(count < array.Length)
//     {
//         Write($"{array[count] = rnd.Next(1,5)} ");
//         count++;
//     }
// }

// // считаем данные
// void findnumber(int[] numb)
// {
//     int count = 0;
//     int num = numb.Length;
//     int aa = 0;
//     int bb = numb.Length;
//     while(count < numb.Length)
//     {
//         num = numb[aa] * numb[bb-1];
//         Write($"{num} ");
//         aa++;
//         bb--;
//         count++;
//     }
// }


// int[] arr = new int[5];
// CreateArray(arr);
// Write("\n");
// findnumber(arr);


