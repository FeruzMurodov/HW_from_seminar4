/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine()!);

int getDegree(int A, int B)
{
    int result = Convert.ToInt32(Math.Pow(A, B));
    return result;
}

int genResult = getDegree(numA, numB);
Console.WriteLine($"{genResult}");