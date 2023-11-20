using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace tortiki
{
    public class Tort
    {
        public string Forma;
        public string Size;
        public string Vkus;
        public string Count;
        public string Glazure;
        public string Dekor;

        public Tort() { }
        public void set_in_tort(string value, int in_list)
        {
            switch (in_list)
            {
                case 0:
                    Forma = value; break;
                case 1:
                    Size = value; break;
                case 2:
                    Vkus = value; break;
                case 3:
                    Count = value; break;
                case 4:
                    Glazure = value; break;
                case 5:
                    Dekor = value; break;
            }
        }

        public string Info()
        {
            string text = "";
            if (Forma != null)
                text += " - Форма: " + Forma + '\n';
            if (Size != null)
                text += " - Размер: " + Size + '\n';
            if (Vkus != null)
                text += " - Вкус: " + Vkus + '\n';
            if (Count != null)
                text += " - Количество коржей: " + Count + '\n';
            if (Glazure != null)
                text += " - Глазурь: " + Glazure + '\n';
            if (Dekor != null)
                text += " - Декор: " + Dekor + '\n';
            return text;
        }
        public List<string> get_input_podpunkt()
        {
            List<string> result = new List<string>();
            if (Forma != null)
                result.Add(Forma);
            if (Size != null)
                result.Add(Size);
            if (Vkus != null)
                result.Add(Vkus);
            if (Count != null)
                result.Add(Count);
            if (Glazure != null)
                result.Add(Glazure);
            if (Dekor != null)
                result.Add(Dekor);
            return result;
        }
    }
    public class Zakaz
    {
        private DateTime Date;
        private Tort Tort;
        private int Price;
        public Zakaz(Tort tort, int price)
        {
            Date = DateTime.Now;
            Tort = tort;
            Price = price;
            append_zakaz();
        }

        private void append_zakaz()
        {
            if (!File.Exists("zakaz.txt"))
                File.WriteAllText("zakaz.txt", "");
            File.AppendAllText("zakaz.txt", "Дата заказа: " + Date.ToLongDateString() + "\n\tСам заказ:\n" + Tort.Info() + '\n'+"Сумма заказа = "+Price+"\n\n");
        }
    }

    public class Work
    {
        private static Tort tort = new Tort();
        private static int price_result = 0;
        private static Dictionary<string, List<string>> podpunkts = new Dictionary<string, List<string>>()
        {
            {"Форма", new List<string>{"Сердце", "Круг", "Квадрат", "Ромб", "Овал"}},
            {"Размер", new List<string>{"Мизерный", "Маленький", "Средний", "Большой", "Гигантский"}},
            {"Вкус", new List<string>{"Клубника", "Шоколад", "Вишня", "Банан", "Черешня"}},
            {"Количество коржей", new List<string>{"Один", "Два", "Три", "Сорок", "Тыща"}},
            {"Глазурь", new List<string>{"Клубника", "Шоколад", "Вишня", "Банан", "Черешня"}},
            {"Декор", new List<string>{"В стиле металлик", "Голый торт", "Каскадное конфети", "Башни Makarons", "Английский сад"}}
        };
        private static Dictionary<string, int> price = new Dictionary<string, int>()
        {
            {"Сердце", 400},
            {"Круг", 400},
            {"Ромб", 400},
            {"Овал", 400},
            {"Квадрат", 400},
            {"Мизерный", 200},
            {"Маленький", 300},
            {"Средний", 400},
            {"Большой", 500},
            {"Гигантский", 600},
            {"Клубника", 200},
            {"Шоколад", 200},
            {"Вишня", 200},
            {"Банан", 200},
            {"Черешня", 200},
            {"В стиле металлик", 600},
            {"Голый торт", 400},
            {"Каскадное конфети", 700},
            {"Башни Makarons", 800},
            {"Английский сад", 500},
            {"Один", 100},
            {"Два", 200},
            {"Три", 300},
            {"Сорок", 4000},
            {"Тыща", 100000},
        };

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Собери свой торт:\n__________________________________");
            output(podpunkts.Keys.ToList());
            Console.WriteLine("Итоговая цена:"+price_result);
            Console.WriteLine(tort.Info());
            int pos = strelki(podpunkts.Keys.ToList(), true);
            if (pos == 0)
            {
                new Zakaz(tort, price_result);
                price_result = 0;
                tort = new Tort();
                Menu();
            }
            Console.Clear();
            Console.WriteLine($"Выбери подходящее для пункта {podpunkts.Keys.ToList()[pos - 2]}:\n__________________________________");
            output(podpunkts[podpunkts.Keys.ToList()[pos - 2]], true);
            int podpunkt = strelki(podpunkts[podpunkts.Keys.ToList()[pos - 2]]);
            if (podpunkt == 0)
                Menu();
            tort.set_in_tort(podpunkts[podpunkts.Keys.ToList()[pos - 2]][podpunkt - 2], pos-2);
            price_result = 0;
            foreach (var a in tort.get_input_podpunkt())
                price_result += price[a];
            Menu();
        }
        private static void output(List<string> list, bool podpunkt = false)
        {
            string result = "";
            foreach (var a in list)
            {
                result += $"  {a}";
                if (podpunkt)
                    result += $" - {price[a]}";
                result += '\n';
            }
            Console.WriteLine(result);
        }
        private static int strelki(List<string> list, bool menu = false)
        {
            ConsoleKeyInfo key;
            int pos = 2;
            Console.SetCursorPosition(0, pos);
            Console.Write("->");
            do
            {
                Console.SetCursorPosition(0, pos);
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos -= 1;
                    if (pos < 2)
                        pos = list.Count + 1;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos += 1;
                    if (pos > list.Count + 1)
                        pos = 2;
                }
                else if (key.Key == ConsoleKey.Spacebar && menu)
                    return 0;
                else if (key.Key == ConsoleKey.Escape && !menu)
                    return 0;
                Console.Write("  ");
                Console.SetCursorPosition(0, pos);
                Console.Write("->");
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}