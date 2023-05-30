using static System.Console;
Clear();

// Sqrt -- квадратный корень из числа, Pow -- это возведение в степень, Sqrt --- частный случай Pow. 
// Pow(4,1/2)==Sqrt(4)



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void CreateArray(int[] array)
{
    Random rnd = new Random();
    int count = 0;
    while(count < array.Length)
    {
        Write($"{array[count] = rnd.Next(100,999)} ");
        count++;
    }
}

void positivNumber(int[] positive)
{
    int count = 0;
    int pos = 0;
    int a = 0;
    while (count < positive.Length)
    {
        pos =+ positive[count];
        //Write($"{pos} ");
        {
            if (pos % 2 == 0)
            {
                a++;
            }
        }
        count++;
    }
    Write($" - {a} ");
}

int[] arr = new int[4];
CreateArray(arr);
positivNumber(arr);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void CreateArray(int[] array)
{
    Random rnd = new Random();
    int count = 0;
    while(count < array.Length)
    {
        Write($"{array[count] = rnd.Next(1,10)} ");
        count++;
    }
}

void positivNumber(int[] positive)
{
    int count = 0;
    int pos = positive.Length;
    int a = 0;
    while(count < pos)
    {
        if (positive[count] % 2 != 0)
        a += positive[count];
        count++;
    }
    WriteLine($"сумма чисел на не четных позициях: {a}");
}

int[] arr = new int[5];
CreateArray(arr);
Write("\n");
positivNumber(arr);



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void CreateArray(int[] array)
{
    Random rnd = new Random();
    int count = 0;
    while(count < array.Length)
    {
        Write($"{array[count] = rnd.Next(1,20)} ");
        count++;
    }
}

void differenceArray(int[] difference)
{
    int count = 0;
    int array = difference.Length;
    int min = 1000;
    int max = 0;
    while(count < array)
    {
        if(difference[count] > max)
        {
            max =+ difference[count];
        }
        if (difference[count] <= min)
        {
            min =+ difference[count];
        }
        count++;
    }
    WriteLine($"- {max - min}");

}


int[] arr = new int[5];
CreateArray(arr);
differenceArray(arr);






