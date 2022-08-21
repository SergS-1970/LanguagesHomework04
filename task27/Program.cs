/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


if (numberN < 0) numberN *= -1;
int SumDigitN = 0;
while (numberN / 1 != 0)
{
    SumDigitN += (numberN % 10);
    numberN /= 10;
}

Console.WriteLine($"Сумма цифр в числе = {SumDigitN}");
