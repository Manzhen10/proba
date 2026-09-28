using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N: ");

        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            // Проверка на кратность 10
            if (n % 10 == 0)
            {
                Console.WriteLine($"Число {n} является кратным 10.");
            }
            else
            {
                Console.WriteLine($"Число {n} не является кратным 10.");
            }

            // Вывод таблицы квадратов 
            Console.WriteLine("Таблица квадратов:");
            Console.WriteLine("Число | Квадрат");
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i,5} | {i * i,7}");
            }
        }
        else
        {
            Console.WriteLine("Введите корректное число.");
        }
    }
}