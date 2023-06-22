/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int getSumOfNumbers(int number)
{
	int count = 0;
	while (number > 0 )
	{
		count = count + number % 10;
		number = number / 10 ;
	}
	return count;
}

Console.WriteLine($"Сумма цифр числа {num} равно {getSumOfNumbers(num)}");
