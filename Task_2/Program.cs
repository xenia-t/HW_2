// Написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
Random rnd = new Random();
int number = rnd.Next(100, 999);

int number1 = number/100;
int number2 = number%10; 
Console.WriteLine($"{number} => {number1}{number2}");

