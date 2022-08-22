/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18"
*/

Console.Write("Введите начальное число: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int finish = Convert.ToInt32(Console.ReadLine());
Console.Write("Начальное число = " + start + "; Конечное число = " + finish + ". -> ");
while(start <= finish)
{
    if (start % 3 == 0)
    {
        Console.Write(start + ", ");
        start = start + 3;
    }
    else start++;
}
Console.WriteLine("");
Console.ReadKey(true);