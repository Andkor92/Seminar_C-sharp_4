// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; number > 0; i++)
{
    int lastDigit = number % 10;
    sum = sum + lastDigit;
    number = number / 10;
}
Console.WriteLine($"Сумма цифр числа составляет {sum}.");
