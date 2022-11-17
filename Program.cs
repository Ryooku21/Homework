// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два целых числа");
int firstDigit = Convert.ToInt32(Console.ReadLine());
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit == secondDigit) {
    Console.WriteLine($"Оба числа равны {firstDigit} = {secondDigit}");
}
    else
    if (firstDigit > secondDigit) {
        Console.WriteLine($"Первое число {firstDigit} больше, чем второе {secondDigit}");
}   else
{
        Console.WriteLine($"Второе число {secondDigit} больше, чем первое {firstDigit}");
}