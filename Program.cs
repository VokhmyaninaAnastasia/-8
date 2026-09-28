//*****************************************************************************
//*Практическая работа №5                                                     *
//* Выполнила: Вохмянина А.Р., группа 2-ИСП                                   *
//* Задание: составление программы циклической структуры: цикл с предусловием *
//*****************************************************************************
using System;

namespace работа_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Практическая работа 8.";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                Console.Write("Здравствуйте! Введите стоимость телефона N: ");
                int N = int.Parse(Console.ReadLine());

                Console.Write("Введите сумму, которую Мария откладывает в день K: ");
                int K = int.Parse(Console.ReadLine());
                int sum = 0;
                int days = 0;
                int weekDay = 1;// 1- понедельник

                while (sum < N)
                {
                    days++;
                    if (weekDay != 6) // не суббота
                    {
                        sum += K;
                    }
                    weekDay++;
                    if (weekDay > 7)
                    {
                        weekDay = 1;
                    }
                }
                Console.WriteLine($"Мария накопит нужную сумму за {days} дней");
                Console.WriteLine($"Накопленная сумма: {sum} рублей");
            }
            catch
            {
                Console.WriteLine("Ошибка! Введите целые числа.");
            }
            Console.ReadKey();
        }
    }
}

