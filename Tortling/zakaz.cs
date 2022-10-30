using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tortling
{
    internal class zakaz
    {
        public static void PeePeePoPoCheck()
        {
            Console.WriteLine("Выберите тортик и его составляющие");
            Console.WriteLine("  Выбор формы");
            Console.WriteLine("  Выбор размера коржа");
            Console.WriteLine("  Выбор вкуса");
            Console.WriteLine("  Выбор кол-ва коржей");
            Console.WriteLine("  Выбор глазури для торта");
            Console.WriteLine("  Выбор декора для торта");
            Console.WriteLine("Ваш заказ: ");
            int position = 0;
            ConsoleKeyInfo Ctrelka = Console.ReadKey();
            Console.SetCursorPosition(1, position);
            while (Ctrelka.Key != ConsoleKey.Escape)
            {
                if (Ctrelka.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                }
                if (Ctrelka.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                }
                Console.SetCursorPosition(1, position);
                Console.WriteLine("->");


                if ((position == 1) && (Ctrelka.Key == ConsoleKey.Enter))
                {
                    Console.Clear();
                    Console.WriteLine("  Квадратный 222руб");
                    Console.WriteLine("  Круглый 333руб");
                    Console.WriteLine("  Треугольный 444руб");
                    Console.WriteLine("  Овальный 555руб");
                    Ctrelka = Console.ReadKey();
                    while (Ctrelka.Key != ConsoleKey.Escape)
                    {

                            if (Ctrelka.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, position++);
                            }
                            if (Ctrelka.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, position--);
                            }
                            Console.SetCursorPosition(1, position);
                            Console.WriteLine("->");
                            Console.Clear();
                        if ((position == 1) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.WriteLine("Выберите тортик и его составляющие");
                            Console.WriteLine("  Выбор формы");
                            Console.WriteLine("  Выбор размера коржа");
                            Console.WriteLine("  Выбор вкуса");
                            Console.WriteLine("  Выбор кол-ва коржей");
                            Console.WriteLine("  Выбор глазури для торта");
                            Console.WriteLine("  Выбор декора для торта");
                            Console.WriteLine("Ваш заказ: Квадратный 222руб ");

                        }


                        if ((position == 2) && (Ctrelka.Key == ConsoleKey.Enter))
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите тортик и его составляющие");
                            Console.WriteLine("  Выбор формы");
                            Console.WriteLine("  Выбор размера коржа");
                            Console.WriteLine("  Выбор вкуса");
                            Console.WriteLine("  Выбор кол-ва коржей");
                            Console.WriteLine("  Выбор глазури для торта");
                            Console.WriteLine("  Выбор декора для торта");
                            Console.WriteLine("Ваш заказ: Круглый 333руб ");
                        }
                        if ((position == 3) && (Ctrelka.Key == ConsoleKey.Enter))
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите тортик и его составляющие");
                            Console.WriteLine("  Выбор формы");
                            Console.WriteLine("  Выбор размера коржа");
                            Console.WriteLine("  Выбор вкуса");
                            Console.WriteLine("  Выбор кол-ва коржей");
                            Console.WriteLine("  Выбор глазури для торта");
                            Console.WriteLine("  Выбор декора для торта");
                            Console.WriteLine("Ваш заказ: Треугольный 444руб ");
                        }
                        if ((position == 4) && (Ctrelka.Key == ConsoleKey.Enter))
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите тортик и его составляющие");
                            Console.WriteLine("  Выбор формы");
                            Console.WriteLine("  Выбор размера коржа");
                            Console.WriteLine("  Выбор вкуса");
                            Console.WriteLine("  Выбор кол-ва коржей");
                            Console.WriteLine("  Выбор глазури для торта");
                            Console.WriteLine("  Выбор декора для торта");
                            Console.WriteLine("Ваш заказ: Овальный 555руб ");
                        }
                    }
                   
                }
                else if ((position == 2) && (Ctrelka.Key == ConsoleKey.Enter))
                {
                    Console.Clear();
                    Console.WriteLine("17 см 111руб");
                    Console.WriteLine("30 см 222 руб");
                    Console.WriteLine("45 см 333рую");
                    Ctrelka = Console.ReadKey();
                    while (Ctrelka.Key != ConsoleKey.Escape)
                    {

                            

                                if (Ctrelka.Key == ConsoleKey.DownArrow)
                                {
                                    Console.SetCursorPosition(0, position++);
                                }
                                if (Ctrelka.Key == ConsoleKey.UpArrow)
                                {
                                    Console.SetCursorPosition(0, position--);
                                }
                                Console.SetCursorPosition(1, position);
                                Console.WriteLine("->");
                            if ((position == 1) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите тортик и его составляющие");
                                Console.WriteLine("  Выбор формы");
                                Console.WriteLine("  Выбор размера коржа");
                                Console.WriteLine("  Выбор вкуса");
                                Console.WriteLine("  Выбор кол-ва коржей");
                                Console.WriteLine("  Выбор глазури для торта");
                                Console.WriteLine("  Выбор декора для торта");
                                Console.WriteLine("Ваш заказ: 17см 111руб ");



                                if ((position == 2) && (Ctrelka.Key == ConsoleKey.Enter))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Выберите тортик и его составляющие");
                                    Console.WriteLine("  Выбор формы");
                                    Console.WriteLine("  Выбор размера коржа");
                                    Console.WriteLine("  Выбор вкуса");
                                    Console.WriteLine("  Выбор кол-ва коржей");
                                    Console.WriteLine("  Выбор глазури для торта");
                                    Console.WriteLine("  Выбор декора для торта");
                                    Console.WriteLine("Ваш заказ: 30см 222руб ");
                                }
                                if ((position == 3) && (Ctrelka.Key == ConsoleKey.Enter))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Выберите тортик и его составляющие");
                                    Console.WriteLine("  Выбор формы");
                                    Console.WriteLine("  Выбор размера коржа");
                                    Console.WriteLine("  Выбор вкуса");
                                    Console.WriteLine("  Выбор кол-ва коржей");
                                    Console.WriteLine("  Выбор глазури для торта");
                                    Console.WriteLine("  Выбор декора для торта");
                                    Console.WriteLine("Ваш заказ: 45см 333руб ");
                                }
                            

                        }
                    }
                   
                }
                else if ((position == 3) && (Ctrelka.Key == ConsoleKey.Enter))
                {
                    Console.Clear();
                    Console.WriteLine("Чоколадный 555руб");
                    Console.WriteLine("Ванильный 666руб");
                    Console.WriteLine("Вишневый 777руб");
                    Ctrelka = Console.ReadKey();
                    while (Ctrelka.Key != ConsoleKey.Escape)
                    {
                        


                            if (Ctrelka.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, position++);
                            }
                            if (Ctrelka.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, position--);
                            }
                            Console.SetCursorPosition(1, position);
                            Console.WriteLine("->");
                            if ((position == 1) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                            Console.WriteLine("Выберите тортик и его составляющие");
                            Console.WriteLine("  Выбор формы");
                            Console.WriteLine("  Выбор размера коржа");
                            Console.WriteLine("  Выбор вкуса");
                            Console.WriteLine("  Выбор кол-ва коржей");
                            Console.WriteLine("  Выбор глазури для торта");
                            Console.WriteLine("  Выбор декора для торта");
                            Console.WriteLine("Ваш заказ: Чоколадный 555руб ");



                            if ((position == 2) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите тортик и его составляющие");
                                Console.WriteLine("  Выбор формы");
                                Console.WriteLine("  Выбор размера коржа");
                                Console.WriteLine("  Выбор вкуса");
                                Console.WriteLine("  Выбор кол-ва коржей");
                                Console.WriteLine("  Выбор глазури для торта");
                                Console.WriteLine("  Выбор декора для торта");
                                Console.WriteLine("Ваш заказ: Ванильный 666руб ");
                            }
                            if ((position == 3) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите тортик и его составляющие");
                                Console.WriteLine("  Выбор формы");
                                Console.WriteLine("  Выбор размера коржа");
                                Console.WriteLine("  Выбор вкуса");
                                Console.WriteLine("  Выбор кол-ва коржей");
                                Console.WriteLine("  Выбор глазури для торта");
                                Console.WriteLine("  Выбор декора для торта");
                                Console.WriteLine("Ваш заказ: Вишневый 777руб ");
                            }


                        }
                    }
                    
                }
                else if ((position == 4) && (Ctrelka.Key == ConsoleKey.Enter))
                {
                    Console.Clear();
                    Console.WriteLine("32 коржа 111руб");
                    Console.WriteLine("256 коржей 222руб");
                    Console.WriteLine("1024 коржа 333руб");
                    Ctrelka = Console.ReadKey();
                    while (Ctrelka.Key != ConsoleKey.Escape)
                    {
                        


                            if (Ctrelka.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, position++);
                            }
                            if (Ctrelka.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, position--);
                            }
                            Console.SetCursorPosition(1, position);
                            Console.WriteLine("->");
                        if((position == 1) && (Ctrelka.Key == ConsoleKey.Enter))
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите тортик и его составляющие");
                            Console.WriteLine("  Выбор формы");
                            Console.WriteLine("  Выбор размера коржа");
                            Console.WriteLine("  Выбор вкуса");
                            Console.WriteLine("  Выбор кол-ва коржей");
                            Console.WriteLine("  Выбор глазури для торта");
                            Console.WriteLine("  Выбор декора для торта");
                            Console.WriteLine("Ваш заказ: 32 коржа 111руб ");



                            if ((position == 2) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите тортик и его составляющие");
                                Console.WriteLine("  Выбор формы");
                                Console.WriteLine("  Выбор размера коржа");
                                Console.WriteLine("  Выбор вкуса");
                                Console.WriteLine("  Выбор кол-ва коржей");
                                Console.WriteLine("  Выбор глазури для торта");
                                Console.WriteLine("  Выбор декора для торта");
                                Console.WriteLine("Ваш заказ: 256 коржей 222руб ");
                            }
                            if ((position == 3) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите тортик и его составляющие");
                                Console.WriteLine("  Выбор формы");
                                Console.WriteLine("  Выбор размера коржа");
                                Console.WriteLine("  Выбор вкуса");
                                Console.WriteLine("  Выбор кол-ва коржей");
                                Console.WriteLine("  Выбор глазури для торта");
                                Console.WriteLine("  Выбор декора для торта");
                                Console.WriteLine("Ваш заказ: 1024 коржа 333руб ");
                            }


                        }
                    }
                    
                }
                else if ((position == 5) && (Ctrelka.Key == ConsoleKey.Enter))
                {
                    Console.Clear();
                    Console.WriteLine("Чоколадный 888руб");
                    Console.WriteLine("Ванильный 999руб");
                    Console.WriteLine("Вишневый 777руб");
                    Ctrelka = Console.ReadKey();
                    while (Ctrelka.Key != ConsoleKey.Escape)
                    {



                            if (Ctrelka.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, position++);
                            }
                            if (Ctrelka.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, position--);
                            }
                            Console.SetCursorPosition(1, position);
                            Console.WriteLine("->");
                            if ((position == 1) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                            Console.WriteLine("Выберите тортик и его составляющие");
                            Console.WriteLine("  Выбор формы");
                            Console.WriteLine("  Выбор размера коржа");
                            Console.WriteLine("  Выбор вкуса");
                            Console.WriteLine("  Выбор кол-ва коржей");
                            Console.WriteLine("  Выбор глазури для торта");
                            Console.WriteLine("  Выбор декора для торта");
                            Console.WriteLine("Ваш заказ: Чоколадный 888руб ");



                            if ((position == 2) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите тортик и его составляющие");
                                Console.WriteLine("  Выбор формы");
                                Console.WriteLine("  Выбор размера коржа");
                                Console.WriteLine("  Выбор вкуса");
                                Console.WriteLine("  Выбор кол-ва коржей");
                                Console.WriteLine("  Выбор глазури для торта");
                                Console.WriteLine("  Выбор декора для торта");
                                Console.WriteLine("Ваш заказ: Ванильный 999руб ");
                            }
                            if ((position == 3) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите тортик и его составляющие");
                                Console.WriteLine("  Выбор формы");
                                Console.WriteLine("  Выбор размера коржа");
                                Console.WriteLine("  Выбор вкуса");
                                Console.WriteLine("  Выбор кол-ва коржей");
                                Console.WriteLine("  Выбор глазури для торта");
                                Console.WriteLine("  Выбор декора для торта");
                                Console.WriteLine("Ваш заказ: Вишневый 777руб ");
                            }


                        }
                    }
                }
                else if ((position == 6) && (Ctrelka.Key == ConsoleKey.Enter))
                {
                    Console.Clear();
                    Console.WriteLine("Посыпка 111руб");
                    Console.WriteLine("Кокосовая стружка 222руб");
                    Console.WriteLine("Полить пивом 3500руб");
                    Ctrelka = Console.ReadKey();

                    while (Ctrelka.Key != ConsoleKey.Escape)
                    {



                            if (Ctrelka.Key == ConsoleKey.DownArrow)
                            {
                                Console.SetCursorPosition(0, position++);
                            }
                            if (Ctrelka.Key == ConsoleKey.UpArrow)
                            {
                                Console.SetCursorPosition(0, position--);
                            }
                            Console.SetCursorPosition(1, position);
                            Console.WriteLine("->");
                            if ((position == 1) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                            Console.WriteLine("Выберите тортик и его составляющие");
                            Console.WriteLine("  Выбор формы");
                            Console.WriteLine("  Выбор размера коржа");
                            Console.WriteLine("  Выбор вкуса");
                            Console.WriteLine("  Выбор кол-ва коржей");
                            Console.WriteLine("  Выбор глазури для торта");
                            Console.WriteLine("  Выбор декора для торта");
                            Console.WriteLine("Ваш заказ: Посыпка 111руб ");



                            if ((position == 2) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите тортик и его составляющие");
                                Console.WriteLine("  Выбор формы");
                                Console.WriteLine("  Выбор размера коржа");
                                Console.WriteLine("  Выбор вкуса");
                                Console.WriteLine("  Выбор кол-ва коржей");
                                Console.WriteLine("  Выбор глазури для торта");
                                Console.WriteLine("  Выбор декора для торта");
                                Console.WriteLine("Ваш заказ: Кокосовая стружка 222руб ");
                            }
                            if ((position == 3) && (Ctrelka.Key == ConsoleKey.Enter))
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите тортик и его составляющие");
                                Console.WriteLine("  Выбор формы");
                                Console.WriteLine("  Выбор размера коржа");
                                Console.WriteLine("  Выбор вкуса");
                                Console.WriteLine("  Выбор кол-ва коржей");
                                Console.WriteLine("  Выбор глазури для торта");
                                Console.WriteLine("  Выбор декора для торта");
                                Console.WriteLine("Ваш заказ: Полить пивом 3500руб ");
                            }


                        }
                    }
                }
                    if (Ctrelka.Key != ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите тортик и его составляющие");
                        Console.WriteLine("  Выбор формы");
                        Console.WriteLine("  Выбор размера коржа");
                        Console.WriteLine("  Выбор вкуса");
                        Console.WriteLine("  Выбор кол-ва коржей");
                        Console.WriteLine("  Выбор глазури для торта");
                        Console.WriteLine("  Выбор декора для торта");
                        Console.WriteLine("Ваш заказ: ");
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                    }
                    Ctrelka = Console.ReadKey();


                }
            }


        
    }
}
