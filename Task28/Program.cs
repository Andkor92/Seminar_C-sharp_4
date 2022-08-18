// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int product = 1;

for (int i = 1; i <= N; i++)
{
    product = product * i;
}
Console.WriteLine($"Сумма чисел от 1 до {N} = {product}");
