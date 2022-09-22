﻿/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет    */

Console.Write("Введите порядковый номер дня недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
void CheckingDayWeek(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else if (dayNum < 1 || dayNum > 7)
    {
        Console.WriteLine("Такого дня недели не существует");
    }
    else Console.WriteLine("Будний день");
}
CheckingDayWeek(dayNum);
