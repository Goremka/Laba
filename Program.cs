using System;
namespace laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №6");
            Console.WriteLine("Обработка исключений");
            
            try
            {
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Результат: {100 / number}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено не число.");
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
            }
        }
    }
}
