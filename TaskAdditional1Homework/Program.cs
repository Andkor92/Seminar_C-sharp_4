// Написать программу для разворота массива

Console.WriteLine("Введите числа через пробел: "); //ВАРИАНТ 1 - Массив из введенных чисел через пробел
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
for (int i = 0; i < array.Length / 2; i++)
{
    int temp =  array[i];
    array[i] = array[(array.Length - 1) - i];
    array[(array.Length - 1) - i] = temp;
}
Console.Write(string.Join((", "), array));



int[] array = new int[30]; //ВАРИАНТ 2 - Массив рандомный с заданными Мин/Макс и размером. В данном случае размер его 30, диапазон значений от 0 до 99 включительно.
Random rand = new Random(); //Сначала вывод рандомного массива, затем его разворот.
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100);
}
Console.Write(string.Join((", "), array));
for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[(array.Length - 1) - i];
    array[(array.Length - 1) - i] = temp;
}
Console.WriteLine("");
Console.Write(string.Join((", "), array));



int[] array = new int[30]; //ВАРИАНТ 2 - Без вывода рандомного массива с заданными Мин/Макс и размером, сразу реверс
Random rand = new Random();
for (int i = 0; i < array.Length / 2; i++)
{
    array[i] = rand.Next(0, 100);
    array[(array.Length - 1) - i] = rand.Next(0, 100);
    int temp = array[i];
    array[i] = array[(array.Length - 1) - i];
    array[(array.Length - 1) - i] = temp;
}
Console.WriteLine("");
Console.Write(string.Join((", "), array));
