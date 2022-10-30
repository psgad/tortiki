using тохтик;
bb.nachalo(2, 1);
bb.vb(2, 8, 1, 1);
bb.vv(1);
bb.och();
ConsoleKeyInfo a;
do
{
    Console.Clear();
    Console.WriteLine("Спасибо за заказ, если хотите сделать еще один заказ - нажмите любую клавишу, если нет - введите 0");
    a = Console.ReadKey();
    if (a.Key == ConsoleKey.D0)
    {
        Console.Clear();
        Console.WriteLine("Спасибо, что сделали заказ в нашей кондитерской, ждем Ваш заказ еще раз\u263a");
        break;
    }
    else
    {
       
        bb.nachalo(2, 1);
        bb.vb(2, 8, 1, 1);
        bb.vv(2);
        bb.och();
    }
} while (true);
