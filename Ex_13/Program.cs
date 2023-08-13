// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int CalcDigits(int number)
{
    int counter = 0;

    while (number > 0)
    {
        number = number / 10;
        counter++;
    }
    return counter;
}

int Power10(int exponent)
{
    int counter = 0;
    int power = 1;
    while (counter < exponent)
    {
        power = power * 10;
        counter++;
    }
    return power;
}

int ThirdDigit(int number)
{
    int digits = CalcDigits(number);
    if (digits < 3) return -1;
    int exponent = digits - 3;
    int digits3 = number / Power10(exponent);
    return digits3 % 10;
}


    int num = InputNum("Введите целое число больше 99: ");

    if (ThirdDigit(num) != -1)
        Console.WriteLine($"Третья слева цифра числа {num} равна {ThirdDigit(num)}");
    else
        Console.WriteLine($"В числе менее трёх цифр!!!");
