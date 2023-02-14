// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите 3х значное число");
if (number >= 100 && number < 1000)
{
    int lastDigit = number % 10;
    System.Console.WriteLine($"последняя цифра числа {number} равна {lastDigit}");
}