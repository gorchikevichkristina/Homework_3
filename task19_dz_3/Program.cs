// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

﻿Console.WriteLine("Введите пятизначное число:");
int number=Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;

 if (amount < 5 | amount > 5)
 {  
    Console.WriteLine("Это не пятизначное число");
 }
 else 
 {
    Console.WriteLine(number); // на количество цифр проверяет, осталось сравнение
 }

