// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число");
int singleDigit = Convert.ToInt32(Console.ReadLine());
int step = 1;

while (step <= singleDigit) 
{
    if (step % 2 == 0) 
    {
        Console.WriteLine(step);
    } 
        step++;
}

if (singleDigit < 0) {
    while (step >= singleDigit) 
{
    if (step % 2 == 0) 
    {
        Console.WriteLine(step);
    } 
        step--;
}
}