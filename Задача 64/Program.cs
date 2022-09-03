// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Clear();
Console.WriteLine("Задача 64.");

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

NaturalInInterval(M, N);

void NaturalInInterval(int first, int second)
{
    if (first > 0 & second > 0 & first > second)
    {
        for (int result = first; result >= second; result = result - 1)
        {
            Console.Write($"{result} ");
        }
    }

    else if (first > 0 & second > 0 & first < second)
    {
        for (int result = first; result <= second; result++)
        {
            Console.Write($"{result} ");
        }
    }

    else if (first == second)
    {
        Console.Write("Введите числа не равные друг другу");
    }

    else
    {
        Console.Write("Введите числа не равные 0 и не отрицательные");
    }
}
