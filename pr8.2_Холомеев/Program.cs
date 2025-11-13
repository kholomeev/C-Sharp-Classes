namespace pr8_2_Холомеев
{
    // Класс Figura. Метод ShowArea перегружен.
    // В зависимости от количества введенных параметров выводится название фигуры
    // (один параметр – квадрат,
    // два – прямоугольник,
    // три – трапеция), вычисляется и выводится площадь.
    class Figura
    {
        public virtual void ShowArea(double side)
        {
            double area = side * side;
            Console.WriteLine("Эта фигура — квадрат.");
            Console.WriteLine($"Сторона — {side}.");
            Console.WriteLine($"Площадь фигуры — {area}");
        }
        public virtual void ShowArea(double width, double length)
        {
            double area = width * length;
            Console.WriteLine("Эта фигура — прямоугольник.");
            Console.WriteLine($"Стороны — {width} и {length}.");
            Console.WriteLine($"Площадь фигуры — {area}");
        }
        public virtual void ShowArea(double base1, double base2, double height)
        {
            double area = (base1 + base2) / 2 * height;
            Console.WriteLine("Эта фигура — трапеция.");
            Console.WriteLine($"Основания — {base1} и {base2}. Высота — {height}");
            Console.WriteLine($"Площадь фигуры — {area}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura shape1 = new Figura();
            shape1.ShowArea(3);
            Figura shape2 = new Figura();
            shape2.ShowArea(4,6);
            Figura shape3 = new Figura();
            shape3.ShowArea(4,6,10);
        }
    }
}