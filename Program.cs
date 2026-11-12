//*****************************************************************************
//*Практическая работа №8                                                     *
//* Выполнила: Вохмянина А.Р., группа 2-ИСП                                   *
//* Задание: составление программы циклической структуры: итерационный цикл   *
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
            bool repeat = true;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                try
                {
                    Console.Write("Здравствуйте! Введите стоимость телефона: ");
                    uint pricePhone = UInt32.Parse(Console.ReadLine());

                    Console.Write("Введите сумму, которую Мария откладывает в день : ");
                    uint deferredMoney = UInt32.Parse(Console.ReadLine());

                    uint sum = 0;
                    int days = 0;
                    int weekDay = 1;// 1- понедельник

                    while (sum < pricePhone)
                    {
                        days++;
                        if (weekDay != 6) // не суббота
                        {
                            sum += deferredMoney;
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

                catch (ArgumentException aex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Ошибка аргумента: " + aex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Непредвиденная ошибка: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("\nХотите продолжить выполнять программу? (да/нет)");
                string answer = Console.ReadLine();
                repeat = (answer == "да" || answer == "д");
            } while (repeat);
            Console.ReadKey();
        }
    }
}
