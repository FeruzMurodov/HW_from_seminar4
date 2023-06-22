/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */



int[] getArray(int count)
{
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = new Random().Next(0, 9);
    }
    return result;
}

int[] array = getArray(8);
Console.WriteLine($"[{String.Join(";", array)}]");