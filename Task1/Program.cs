// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("Введите несколько чисел через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество введенных вами элементов которые больше нуля - {count}");