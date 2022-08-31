/*Задача 19. Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine()), y=x, r=0;
/*while(y>10)
{
    r+=y%10;
    y/=10;
}
r+=y;
if(x==r) 
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/
/*
static void Main()
{
    string number = Console.ReadLine();
    bool task1 = true;
 
    for (int i = 0; i < (number.Length - 1) / 2; i++)
        if (number[i] != number[number.Length - i - 1])
            task1 = false;
 
    if (task1)
        Console.WriteLine("Палиндром");
    else Console.WriteLine("Не палиндром");
 
    Console.ReadKey();
}
*//*
string number = Console.ReadLine();
bool task = true;
 
for (int i = 0; i < number.Length / 2; i++)
{
    if (number[i] != number[number.Length - i - 1])
        task = false;
 
    if (task)
        Console.WriteLine("Палиндром");
    else 
        Console.WriteLine("Не палиндром");
}
Console.ReadKey();
*/




/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/







/*Задача 23. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
