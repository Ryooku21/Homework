// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите три разных целых числа");
int firstDigit = Convert.ToInt32(Console.ReadLine());
int secondDigit = Convert.ToInt32(Console.ReadLine());
int thirdDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit > secondDigit) {
    if (firstDigit > thirdDigit) 
{
        Console.WriteLine($"Максимальное число равно {firstDigit}");
}
    else {
        Console.WriteLine($"Максимальное число равно {thirdDigit}");
 }}
    else { 
        if (secondDigit > thirdDigit) {

            Console.WriteLine($"Максимальное число равно {secondDigit}");
}
    else {
            Console.WriteLine($"Максимальное число равно {thirdDigit}");
}}