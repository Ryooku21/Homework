// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите три разных целых числа");
int firstDigit = Convert.ToInt32(Console.ReadLine());
int secondDigit = Convert.ToInt32(Console.ReadLine());
int thirdDigit = Convert.ToInt32(Console.ReadLine());

int showmax = firstDigit;
if (showmax > secondDigit && showmax > thirdDigit) {
    Console.WriteLine($"Максимальное число равно {showmax}");
} else
if (showmax < secondDigit && secondDigit > thirdDigit)
{
showmax = secondDigit;
Console.WriteLine($"Максимальное число равно {showmax}");
} else
if (showmax < secondDigit && secondDigit < thirdDigit) {
    showmax = thirdDigit;
Console.WriteLine($"Максимальное число равно {showmax}");
} 
