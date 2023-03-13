/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.Clear();
Console.WriteLine("Введите первое положительное число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе положительное число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(FunctionAck(m , n));

int FunctionAck(int a, int b)
{
    if (a == 0) return b +1;
    else if (b == 0) return FunctionAck(a - 1, 1);
    else return FunctionAck(a - 1, FunctionAck(a, b-1));
}
