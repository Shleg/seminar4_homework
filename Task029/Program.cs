// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

int[] CreateArray()
{
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ый элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

Console.WriteLine(string.Join(", ", CreateArray()));