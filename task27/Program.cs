// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
//82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i;
int sum = 0;

for (i = 1; number > 0; i++)
{
    sum = sum + number % 10;
    number = number / 10;
}

Console.WriteLine($"Сумма цифр в числе составит {sum}");