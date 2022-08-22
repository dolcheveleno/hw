/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNarural(int m, int n)
{
    if (n >= m)
    {
        return m + SumNarural(m + 1, n);
    }
    else
        return 0;
}
Console.Write("Введите начальное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел в промежутке от {numberM} до {numberN} = {SumNarural(numberM, numberN)}");
