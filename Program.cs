// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int number = 0;
Console.WriteLine("ВВедите трехзначное число:");
number = Convert.ToInt32(Console.ReadLine());
int SecondDigit = number / 10;
int ThirdDigit = SecondDigit % 10;
Console.WriteLine("Вторая цифра числа=" + SecondDigit % 10);
