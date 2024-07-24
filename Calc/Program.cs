using System;

class MiniCalculator
{
    // Определение интерфейса для функции сложения
    public static double AddNumbers(double a, double b)
    {
        return a + b;
    }

    // Основная функция
    static void Main(string[] args)
    {
        Console.WriteLine("Мини-калькулятор: сложение двух чисел");

        double num1 = 0;
        double num2 = 0;
        bool isValidInput = false;

        // Ввод первого числа с обработкой ошибок
        while (!isValidInput)
        {
            try
            {
                Console.Write("Введите первое число: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                isValidInput = true; // Ввод корректен, выходим из цикла
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Пожалуйста, введите корректное число.");
            }
        }

        isValidInput = false; // Сброс для следующего ввода

        // Ввод второго числа с обработкой ошибок
        while (!isValidInput)
        {
            try
            {
                Console.Write("Введите второе число: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                isValidInput = true; // Ввод корректен, выходим из цикла
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Пожалуйста, введите корректное число.");
            }
        }

        // Вычисление суммы
        double result = AddNumbers(num1, num2);

        // Вывод результата
        Console.WriteLine($"Сумма {num1} и {num2} равна {result}");

        // Блок finally
        // Здесь мы не можем использовать finally, так как он нужен только с try.
        Console.WriteLine("Спасибо за использование мини-калькулятора!");
    }
}
