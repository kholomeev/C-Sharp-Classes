namespace pr8_1_Холомеев
{
    // 1 вариант. Разработать класс для представления объекта «Прямоугольный параллелепипед». Реализуйте все необходимые поля данных (закрытые) и методы позволяющие: 
    //    – устанавливать и считывать значения полей данных; 
    //    – вычислять объем прямоугольного параллелепипеда; 
    //    – вычислять площадь поверхности прямоугольного параллелепипеда; 
    //    – выводить полную информацию об объекте в консоль. 
    class Parallelepiped(float l, float w, float h)
    {
        private float L { get; set; } = l;
        private float W { get; set; } = w;
        private float H { get; set; } = h;

        public virtual double Volume() => L * W * H;
        public virtual double Area() => 2 * (L*W + L*H + W*H);

        public virtual void Print()
        {
            Console.WriteLine($"Длина, высота и ширина прямоугольного параллелепипеда: {L}, {W}, {H}");
            Console.WriteLine($"Объём: {Volume():f3}, Площадь: {Area():f3}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Parallelepiped obj1 = new Parallelepiped(10, 20, 30);
            obj1.Print();
            Parallelepiped obj2 = new Parallelepiped(2.34f, 23, 5.22f);
            obj2.Print();
            
        }
    }
}
  