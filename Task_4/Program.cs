// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите день недели: ");
string number_day = Console.ReadLine();
int day = int.Parse(number_day);

if (day > 5)
{
    if (day <= 7) Console.WriteLine("Выходной");
    else Console.WriteLine("Введенное значение некорректно. Повторите попытку");
}

else Console.WriteLine("Рабочий день");
