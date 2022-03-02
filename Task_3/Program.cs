// Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Write("Введите число: ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);

int N = A;

if (N / 100 != 0)
{
    while (N > 1000) 
    {
        N /= 10;
    }
    Console.WriteLine($"Третья цифра числа {A}: {N % 10}");
}

else Console.WriteLine($"Третьей цифры у числа {A} нет");

