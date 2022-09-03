// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
Console.WriteLine($"Задача 68.");

Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman = functionAkkerman(m, n);

Console.Write($"Результат = {Akkerman} ");

int functionAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return functionAkkerman(m - 1,1);
  else return functionAkkerman(m - 1, functionAkkerman(m, n - 1));
}