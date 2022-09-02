/*Задача 19. Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

/*Console.Write("Введите число: ");
string number = Console.ReadLine();
bool task1 = true;
 
for (int i = 0; i < (number.Length - 1) / 2; i++)
    if (number[i] != number[number.Length - i - 1])
        task1 = false;
 
    if (task1)
        Console.WriteLine("Палиндром");
    else 
        Console.WriteLine("Не палиндром");
*/

/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
Console.Write ("Введите координаты X1 точки: ");
int x1=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты X2 точки: ");
int x2=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Y1 точки: ");
int y1=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Y2 точки: ");
int y2=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Z1 точки: ");
int z1=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Z2 точки: ");
int z2=Convert.ToInt32(Console.ReadLine());
   
Console.WriteLine("Отрезок= " + Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)));    
*/




/*Задача 23. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Укажите количество элементов для отображения: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 1; i < array.Length+1; i++)
{  
    Console.WriteLine(i*i*i);
}