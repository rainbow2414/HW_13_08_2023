// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
using System.Xml.XPath;

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SecondDigit(int number)
{
    return (number / 10 ) % 10;
}

int num = InputNum("Введите трёхзначное число:");
Console.WriteLine($"Вторая цифра числа {num} равна {SecondDigit(num)}");
