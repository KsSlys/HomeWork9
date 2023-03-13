/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.Clear();
Console.WriteLine("Введите первое число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = int.Parse(Console.ReadLine());
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {SumNumbers(m,n)}");

int SumNumbers (int a, int b)
{
    if (a==b) return a;
    else return a + SumNumbers(a + 1 , b);

}

