// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//Нам разрешили пока не вводить переменные с клавиатуры

double a = 2;
double b = 3;
double c = 7;
double max;
max = a;

if (a > b)
{}
else
    {
        max = b;
    }
if (max > c)
{}
else
    {
        max = c;
    }
Console.WriteLine(max);