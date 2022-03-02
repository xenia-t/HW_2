// See https://aka.ms/new-console-template for more information
Console.Write("Введите трехзначное число: ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);

int second_digit = A/10%10;
Console.WriteLine($"Вторая цифра числа {A}: {second_digit }");

