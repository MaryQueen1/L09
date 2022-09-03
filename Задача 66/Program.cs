// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Задача 66.");

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

SummNaturalInInterval(M, N);

void SummNaturalInInterval(int first, int second)
{
    if (first > 0 & second > 0 & first > second)
    {
        int summ = 0;
        for (int result = first; result >= second; result = result - 1)
        {
            summ = summ + result;
        }
        Console.Write($"{summ} ");
    }

    else if (first > 0 & second > 0 & first < second)
    {
        int summ = 0;
        for (int result = first; result <= second; result++)
        {
            summ = summ + result;
        }
        Console.Write($"{summ} ");
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

// Как идея решения данной задачи:
// это сначала прописать метод нахождения натуральных чисел и возвращение методом массива,
// а после сложить числа этого массива при помощи i++