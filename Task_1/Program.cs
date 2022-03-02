// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);

int second_digit = A/10%10;
Console.WriteLine($"Вторая цифра числа {A}: {second_digit }");

