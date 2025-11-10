namespace pr8_2_Холомеев
{
    // Класс Figura. Метод ShowArea перегружен.
    // В зависимости от количества введенных параметров выводится название фигуры
    // (один параметр – квадрат,
    // два – прямоугольник,
    // три – трапеция), вычисляется и выводится площадь.
    class Figura(double side)
    {
        public double Side { set; get; } = side;

        public virtual double ShowArea() => Side * 4;
    }
    class Rectangle(double length, double width) : Figura(length)
    {
        public double Width { set; get; } = width;

        public override double ShowArea() => length * width;
    }

    class Trapede(double height, double base1, double base2) : Figura(height)
    {
        public double Base1 { set; get; } = base1;
        public double Base2 { set; get; } = base2;

        public override double ShowArea() => (Base1 + Base2) / 2 * height;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}