// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 81

/*Console.Write("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(x % 10);
*/

///Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (a>b)
{
    max=a;
}
if (a<b)
{
    max =b;
} 
 Console.WriteLine(max);
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b>max)
{
    max=b;
}
if (c>max)
{
    max=c;
} 
 Console.WriteLine(max);
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

/*Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 ==0)
{ 
    Console.WriteLine("Данное число четное.");
}

else
{
    Console.WriteLine("Данное число не четное.");
} */

//OR

/*if((a&1)==1)
    Console.WriteLine("Нечетное значение");
else
    Console.WriteLine("Четное значение");
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int i = 1;


for (i=1; i <= m; i++)
{
    if (i % 2 == 0)
    {
        Console.Write((i)+(" "));
    }
};
*/


/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*Console.Write("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());*/

/*Console.WriteLine((x%100)/10);
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.WriteLine(k < 0 ? "Третьей цифры нет" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*Console.Write("Введите числом день недели: ");
int day=int.Parse(Console.ReadLine());

if(day<=5)
{
    Console.WriteLine("Рабочий");
}
else
{
    Console.WriteLine("Выходной");
}
*/





/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/





/*Задача 26: Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*int DigitsCount(int number){
    int count = 0;
    for ()
}*/


/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/







/*Задача 28: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

/*Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int i = 1;
for (i=1; i <= m; i++)
{
    if (i % 2 == 0)
    {
        Console.Write((i)+(" "));
    }
};
*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/







/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/







/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

/*
int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);

    return array;
}


int SumNegative(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            summa = summa + array[i];
    }

    return summa;
}


int SumPositive(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            summa = summa + array[i];
    }

    return summa;
}


int[] array = new int[12];
array = NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Сумма отрицательных элементов: " + SumNegative(array));
Console.WriteLine("Сумма положительных элементов: " + SumPositive(array));
*/

/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

/*void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}


void znak(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
}


int[] array = new int[10];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
znak(array);
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
*/

/*{
    Console.Write("Введите начальное значение диапазона: ");
    int begin = Convert.ToInt32(Console.ReadLine());;
    Console.Write("Введите начальное значение диапазона: ");
    int end = Convert.ToInt32(Console.ReadLine());;
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(begin, end + 1);
}


void znak(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
}

Console.Write("Укажите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
znak(array);
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
*/


/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

/*
void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}


string SearchNumberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return ("Число " + number + " есть в массиве");
    }
    return ("Числа " + number + " нет 
void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}


string SearchNumberInArray(int[] array, int number)
{
    foreach (int i in array)
    {
        if (i == number)
            return ("Число " + number + " есть в массиве");
    }
    return ("Числа " + number + " нет в массиве");
}

Console.Write("Укажите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.Write("Укажите число, которое Вы хотите найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SearchNumberInArray(array, number));
*/


/*void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}


string SearchNumberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return ("Число " + number + " есть в массиве");
    }
    return ("Числа " + number + " нет в массиве");
}

Console.Write("Укажите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.Write("Укажите число, которое Вы хотите найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SearchNumberInArray(array, number));
*/


/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/







/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

/*void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}


int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count++;
    }
    return count;
}


int[] array = new int[123];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Кол-во чисел, которое лежит в интервале [10; 99]: " + CountNumbers(array));
*/


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/






/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

/*void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 10);
}

int[] PairsMultuplicationInArray(int[] array)
{
    int newlen;
    if (array.Length % 2 == 0)
        newlen = array.Length / 2;
    else
        newlen = array.Length / 2 + 1;

    int[] arr2 = new int[newlen];
    for (int i = 0; i < newlen; i++)
    {
        arr2[i] = array[i] * array[array.Length - i - 1];
    }
    return arr2;
}


Console.Write("Количесто элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Результат: " + string.Join(" ", PairsMultuplicationInArray(array)));
*/

//

/*string check(int n)
{
    string? result = "";
    while (n > 0)
    {
        int x = n % 2;
        result = Convert.ToString(x) + result;
        n /= 2;
    }
    return result;

}
Console.Write("Введите число, которое необходимо перевести в 2-ую систему: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(check(n));
*/


/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3, 7, 22, 2, 78] -> 76
*/





/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*Console.Write("Введите числа (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество чисел больше 0: > {count}");
*/



/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
*/




/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

/*void check(int n)
{
    int numberOne = 0;
    int numberTwo = 1;
    for (int i = 0; i < n; i++)
    {
        Console.Write(numberOne + " ");
        int x = numberOne + numberTwo;
        numberOne = numberTwo;
        numberTwo = x;
    }
}
Console.Write("Укажите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
check(n);
*/

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

int[] CreateArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    
    return copyArray;
}

Console.Write("Укажите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] copyArray = new int[n];
NewArray(array);
Console.WriteLine("Исходный массива [" + string.Join(", ", array) + "]");
copyArray = CreateArray(array);
copyArray[0] = 20;
Console.WriteLine("Исходный массива [" + string.Join(", ", copyArray) + "]");
*/


/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/





/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/





/*Задача 51: Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1;1) и т.д. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/








/*Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/







/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/





/*Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение 
для пользователя.
*/







/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка
*/




/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/




/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных 
чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/




/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

