// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool IsWeekend(int number)
{
    return (number == 7 || number == 6);
}

int num = InputNum("Введите номер дня недели: ");
if (IsWeekend(num))
    Console.WriteLine("Выходной!!!");
else
    Console.WriteLine("Не выходной!!!");