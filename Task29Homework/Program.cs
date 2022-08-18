// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вводим массив через консоль

Console.WriteLine("Введите элементы массива через пробел: "); //ВАРИАНТ 1 - Ввод элементов массива через пробел и вывод массива, состоящего из первых 8 элементов.
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int i;
Console.Write("Массив из первых 8 элементов: [");
for (i = 0; i < 7; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write(array[i] + "]");



Console.WriteLine("Введите 8 элементов массива через пробел: "); //ВАРИАНТ 2 - Ввод элементов массива через пробел и вывод массива, состоящего из первых 8 элементов (проверка через условие == 8).
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int i;
if (array.Length == 8)
{
    Console.Write("Массив: [");
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[i] + "]");
}
else
{
    Console.Write("Ошибка! Введите 8 элементов!");
}



Console.WriteLine("Введите элементы массива через пробел: "); //ВАРИАНТ 3 - Ввод элементов массива через пробел и вывод массива, состоящего из любого числа элементов.
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int i;
Console.Write("Массив: [");
for (i = 0; i < array.Length - 1; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write(array[i] + "]");



int[] array = new int[8]; //ВАРИАНТ 4 - Ввод элементов массива по запросу консоли (размер массива = 8).
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива N {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Массив: [" + string.Join((", "), array) + "]");



Console.Write("Введите размер массива: "); //ВАРИАНТ 5 - Ввод элементов массива по запросу консоли (размер массива устанавливается вначале по запросу консоли).
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    Console.Write($"Введите элемент массива N {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Массив: [" + string.Join((", "), array) + "]");
