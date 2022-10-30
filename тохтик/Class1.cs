using System.Reflection.Emit;
using System.Runtime.ExceptionServices;

namespace тохтик
{
    internal class bb
    {
        private static int izncena;
        private static List<string> bc = new List<string> { };

        public static int nachalo(int b, int x)
        {
            int h = 12;
            Console.Clear();
            string a = "Выберите параметр торта\n" +
            "----------------------------------\n" +
            "  Форма\n" +
            "  Размер\n" +
            "  Вкус коржей\n" +
            "  Количество коржей\n" +
            "  Глазурь\n" +
            "  Декор\n" +
            "  Конец заказа";
            Console.WriteLine(a);
            Console.SetCursorPosition(0, b);
            Console.WriteLine("#>");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine($"Итоговая цена: {izncena}");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("Ваш торт: ");
            for (int i = 0; i<bc.Count; i++)
            {   
                Console.SetCursorPosition(0, i+h);
                Console.WriteLine(bc[i]);
            }
            return izncena;
        }
        public static void vb(int x, int y, int a, int per)
        {
            int nom = per;
            int position = x;
            ConsoleKeyInfo strelka;
            do
            {
                perehod(a, position);
                strelka = Console.ReadKey();
                if (strelka.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == (x - 1))
                    {
                        position = x;
                    }
                }
                else if (strelka.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == (y + 1))
                    {
                        position = y;
                    }
                }

            } while (strelka.Key != ConsoleKey.Enter);
            vibor(position, nom);
        }
        private static void pp(int pos)
        {
            nachalo(pos, 1);
        }
        private static void vibor(int pos, int a)
        {
            if (a == 1)
            {
                if (pos == 2)
                {
                    vb(2, 6, 2, 2);
                }
                if (pos == 3)
                {
                    vb(2, 6, 3, 3);
                }
                if (pos == 4)
                {
                    vb(2, 6, 4, 4);
                }
                if (pos == 5)
                {
                    vb(2, 6, 5, 5);

                }
                if (pos == 6)
                {
                    vb(2, 6, 6, 6);
                }
                if (pos == 7)
                {
                    vb(2, 6, 7, 7);
                }
                if (pos == 8)
                {

                }
            }
            if (a == 2)
            {
                if (pos == 2)
                {
                    izncena = izncena + 300;
                    bc.Add("Квадрат = 300");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 3)
                {
                    izncena = izncena + 300;
                    bc.Add("Круг = 300");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 4)
                {
                    izncena = izncena + 300;
                    bc.Add("Сердце = 300");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 5)
                {
                    izncena = izncena + 300;
                    bc.Add("Треугольник = 300");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 6)
                {
                    izncena  = izncena + 300;
                    bc.Add("Параллелограм = 300");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
            }
            if (a == 3)
            {
                if (pos == 2)
                {
                    izncena = izncena + 250;
                    bc.Add("Для мышей = 250");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 3)
                {
                    izncena = izncena + 500;
                    bc.Add("Простой маленький = 500");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 4)
                {
                    izncena = izncena + 750;
                    bc.Add("Средний = 750");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 5)
                {
                    izncena = izncena + 1000;
                    bc.Add("Большой = 1000");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 6)
                {
                    izncena = izncena + 1250;
                    bc.Add("Гигантский = 1250");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
            }
            if (a == 4)
            {
                if (pos == 2)
                {
                    izncena = izncena + 400;
                    bc.Add("Шоколад = 400");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 3)
                {
                    izncena = izncena + 400;
                    bc.Add("Ваниль = 400");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 4)
                {
                    izncena = izncena + 400;
                    bc.Add("Безе = 400");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 5)
                {
                    izncena = izncena + 400;
                    bc.Add("Карамель = 400");
                    vb(2, 8, 1, 1);
                    nachalo(2,  2);
                }
                if (pos == 6)
                {
                    izncena = izncena + 400;
                    bc.Add("Ягоды = 400");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
            }
            if (a == 5)
            {
                if (pos == 2)
                {
                    izncena = izncena + 200;
                    bc.Add("Один корж = 200");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 3)
                {
                    izncena = izncena + 400;
                    bc.Add("Два коржа = 400");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 4)
                {
                    izncena = izncena + 600;
                    bc.Add("Три коржа = 600");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 5)
                {
                    izncena = izncena + 800;
                    bc.Add("Четыре коржа = 800");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 6)
                {
                    izncena = izncena + 1000;
                    bc.Add("Пять коржей = 1000");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
            }
            if (a == 6)
            {
                if (pos == 2)
                {
                    izncena = izncena + 600;
                    bc.Add("Шоколадная = 600");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 3)
                {
                    izncena = izncena + 600;
                    bc.Add("Кремовая = 600");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 4)
                {
                    izncena = izncena + 600;
                    bc.Add("Клубничная = 600");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 5)
                {
                    izncena = izncena + 600;
                    bc.Add("Фруктовая = 600");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 6)
                {
                    izncena = izncena + 600;
                    bc.Add("Ягодная = 600");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
            }
            if (a == 7)
            {
                if (pos == 2)
                {
                    izncena = izncena + 400;
                    bc.Add("Серпантинки = 400");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 3)
                {
                    izncena = izncena + 800;
                    bc.Add("Конфеты = 800");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 4)
                {
                    izncena = izncena + 1200;
                    bc.Add("Фигурки = 1200");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 5)
                {
                    izncena = izncena + 1600;
                    bc.Add("Рандомная тематика = 1600");
                    vb(2, 8, 1, 1);
                    nachalo(2, 2);
                }
                if (pos == 6)
                {
                    string Textt;
                    int position = 1;
                    Console.Clear();
                    Console.WriteLine("Выберите из спиcка");
                    Console.WriteLine($"  Свадебный\n  Ко дню рождения\n  Игровой дизайн\n  Другое");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("#>");
                    ConsoleKeyInfo strelka;
                    do
                    {

                        strelka = Console.ReadKey();
                        if (strelka.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                            if (position == 0)
                            {
                                position = 1;
                            }
                        }
                        else if (strelka.Key == ConsoleKey.DownArrow)
                        {
                            position++; 
                            if (position == 5)
                            {
                                position = 4;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Выберите из спиcка");
                        Console.WriteLine($"  Свадебный\n  Ко дню рождения\n  Игровой дизайн\n  Другое");
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("#>");

                    } while (strelka.Key != ConsoleKey.Enter);
                    if (position == 1)
                    {
                        Textt = "Свадебный";
                        izncena = izncena + 2000;
                        bc.Add($"На выбранную тему ({Textt}) = 2000");
                        vb(2, 8, 1, 1);
                        nachalo(2, 2);
                    }
                    if (position == 2)
                    {
                        Textt = "Ко дню рождения";
                        izncena = izncena + 2000;
                        bc.Add($"На выбранную тему ({Textt}) = 2000");
                        vb(2, 8, 1, 1);
                        nachalo(2, 2);
                    }
                    if (position == 3)
                    {
                        Textt = "Игровой дизайн";
                        izncena = izncena + 2000;
                        bc.Add($"На выбранную тему ({Textt}) = 2000");
                        vb(2, 8, 1, 1);
                        nachalo(2, 2);
                    }
                    if (position == 4)
                    {
                        Console.WriteLine("Введите название тематики");
                        string b = new string(Console.ReadLine());
                        Textt = b; 
                        izncena = izncena + 2000;
                        bc.Add($"На выбранную тематику ({Textt}) = 2000");
                        vb(2, 8, 1, 1);
                        nachalo(2, 2);
                    }
                }
            }
        }
        public static void com1(int b, string a, double c, int v)
        {
            Console.Clear();
            Console.WriteLine($"{a}");
            cena1(c, v);
            Console.SetCursorPosition(0, b);
            Console.WriteLine("#>");
        }
        public static void com2(int b, string a, int c, int v)
        {
            Console.Clear();
            Console.WriteLine($"{a}");
            cena2(c, v);
            Console.SetCursorPosition(0, b);
            Console.WriteLine("#>");
        }


        private static void perehod(int a, int pos)
        {
            if (a == 1)
            {
                pp(pos);
            }
            if (a == 2)
            {
                string text = "Выберите пункт из меню\n--------------------\n  Квадрат\n  Круг\n  Сердце\n  Треугольник\n  Параллелограм\n";
                com2(pos, text, 3, 17);
            }
            if (a == 3)
            {
                string text = "Выберите пункт из меню\n--------------------\n  Для мышей\n  Просто маленький\n  Средний\n  Большой\n  Гиганский\n";
                com1(pos, text, 2.5, 20);
            }
            if (a == 4)
            {
                string text = "Выберите пункт из меню\n--------------------\n  Шоколад\n  Ваниль\n  Безе\n  Карамель\n  Ягоды\n";
                com2(pos, text, 4, 13);
            }
            if (a == 5)
            {
                string text = "Выберите пункт из меню\n--------------------\n  Один корж\n  Два коржа\n  Три коржа\n  Четыре коржа\n  Пять коржей\n";
                com1(pos, text, 2, 13);
            }
            if (a == 6)
            {
                string text = "Выберите пункт из меню\n--------------------\n  Шоколадная\n  Кремовая\n  Клубничная\n  Фруктовая\n  Ягодная\n";
                com2(pos, text, 3, 15);
            }
            if (a == 7)
            {
                string text = "Выберите пункт из меню\n--------------------\n  Серпантинки\n  Конфеты\n  Фигурки\n  Рандомная тематика\n  На выбранную тематику\n";
                com1(pos, text, 4, 24);
            }
            if (a == 8)
            {
                
            }
        }
        private static void cena1(double b, int c)
        {
            int[] a = new int[] { 100, 200, 300, 400, 500 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.SetCursorPosition(c, i + 2);
                Console.WriteLine($" = {a[i] * b}");
            }
        }
        private static void cena2(double b, int c)
        {
            double[] a = new double[] { 100, 100, 100, 100, 100};
            for (int i = 0; i < a.Length; i++)
            {
                Console.SetCursorPosition(c, i + 2);
                Console.WriteLine($" = {a[i] * b}");
            }
        }
        public static void vv(int jjj)
        {
            if (jjj == 1)
            {
                string bcf = "";
                for (int i = 0; i < bc.Count; i++)
                {
                    bcf = bcf + $"{bc[i]}\n";
                }
                File.WriteAllText("C:\\Users\\User\\Desktop\\тохтик\\filik.txt", $"Ваши заказы:\n\nТорт, который состоит из:\n{bcf}\nНа цену: {izncena}");
            }
            if (jjj == 2)
            {
                string bcf = "";
                for (int i = 0; i < bc.Count; i++)
                {
                    bcf = bcf + $"{bc[i]}\n";
                }
                File.AppendAllText("C:\\Users\\User\\Desktop\\тохтик\\filik.txt", $"\n\nТорт, который состоит из:\n{bcf}\nНа цену: {izncena}");
            }
        }
        public static void och()
        {
            izncena = 0;
            bc.Clear();
        }
       
    }
}