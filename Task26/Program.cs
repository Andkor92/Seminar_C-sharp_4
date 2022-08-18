// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberLen = (int)Math.Log10(number) + 1;

Console.WriteLine($"Количество цифр = {numberLen}");

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (number > 10)
// {
//     number /= 10;
//     i += 1;
// }
// Console.WriteLine($"Количество цифр = {i}");
