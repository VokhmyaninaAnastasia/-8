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
            Console.WriteLine("Здравствуй!");
            while (repeat)
            {
                {
                    try
                    {
                        uint pricePhone = 0;
                        while (pricePhone == 0)
                        {
                            // Ввод стоимости телефона с проверкой на 0
                            Console.Write("Введите стоимость телефона: ");

                            if (!UInt32.TryParse(Console.ReadLine(), out pricePhone))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Ошибка! Введите целое неотрицательное число.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (pricePhone == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Ошибка! Стоимость телефона не может быть равна 0. Повторите ввод.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }

                        uint deferredMoney = 0;

                        // Ввод суммы в день с проверкой на 0
                        while (deferredMoney == 0)
                        {
                            {
                                Console.Write("Введите сумму, которую Мария откладывает в день : ");

                                if (!UInt32.TryParse(Console.ReadLine(), out deferredMoney))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Ошибка! Введите целое неотрицательное число.\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (deferredMoney == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Ошибка! Сумма в день не может быть равна 0. Повторите ввод.\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
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
                    Console.Write("\nХотите продолжить выполнять программу? (да/нет) ");
                    string answer = Console.ReadLine();
                    repeat = (answer == "да" || answer == "д");
                } while (repeat) ;
                Console.ReadKey();
            }
        }
    }
}
