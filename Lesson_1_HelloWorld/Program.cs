﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
//456 % 10;
//int x2 = 782 % 10;
//int x3 = 918 % 10;

Console.WriteLine(x % 10);


///Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine(a);
}
Console.WriteLine(b);


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22





//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет







//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8





//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1





//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6







//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет









/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*int DigitsCount(int number){
    int count = 0;
    for ()
}*/



//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120





//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]




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