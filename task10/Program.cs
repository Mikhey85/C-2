//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int EnterDigit()
{
    Console.WriteLine("Ввудите трёхзначное число:");
    int a = int.Parse(Console.ReadLine()!);
    return a;
}
int FirstDigit(int a)
{
    int number = a / 10;
    return number;
}
int SecondDigit(int number)
{
    int result = number % 10;
    return result;
}
void FindSecond (int result)
{
    Console.WriteLine("Вторая цифра нашего числа будет:" + result);
}
int a = EnterDigit();
int number = FirstDigit(a);
int result = SecondDigit(number);
FindSecond(result);
