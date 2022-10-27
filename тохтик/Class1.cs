namespace тохтик
{
    internal class bb
    {
        public static void nachalo(int b)
        {
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
        }
        public static void vb(int x, int y, int a)
        {
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
            vibor(position);
        }
        private static void pp(int pos)
        {
            nachalo(pos);
        }
        private static void vibor(int pos)
        {
            if (pos == 2)
            {
                vb(2, 6, 2);
            }
            if (pos == 3)
            {

            }
            if (pos == 4)
            {

            }
            if (pos == 5)
            {

            }
            if (pos == 6)
            {

            }
            if (pos == 7)
            {

            }
            if (pos == 8)
            {

            }

        }
        public static void den1(int b)
        {
            Console.Clear();
            Console.WriteLine($"Выберите пункт из меню\n--------------------\n  Шоколад\n  Крем\n  Бизе\n  Драже\n  Ягоды\n");
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
                den1(pos);
            }
        }
    }
}
