/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.Write("Введите основание степени A: ");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите натуральный показатель степени B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double AToDegreeB = 1;
for (int exponent = 1; exponent <= numberB; exponent++)
{
    AToDegreeB = AToDegreeB * numberA;
}
Console.WriteLine($"{numberA} в степени {numberB} = {AToDegreeB}");
