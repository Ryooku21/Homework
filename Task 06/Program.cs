﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число");
int singleDigit = Convert.ToInt32(Console.ReadLine());

if (singleDigit == 0) {
    Console.WriteLine("Введите число отличное от 0");
} else
if (singleDigit % 2 == 0) {
    Console.WriteLine("Введенное число является четным");
} else {
    Console.WriteLine("Введенное число является нечетным");
}