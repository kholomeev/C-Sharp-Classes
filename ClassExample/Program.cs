namespace Class
{
    class Man // Родительский класс
    {
        // Свойства
        public string Name { get; set; }
        public int Age { get; set; }
        // Конструктор
        public Man(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Метод
        public virtual void Print() 
        {
            Console.WriteLine(Name);
        }
    } 
    
    class Employee : Man // Дочерний класс
    {
        // Свойства
        public decimal Salary { get; set; }
        public string Title { get; set; }
        // Конструктор
        public Employee(string name, int age, decimal salary, string title) : base(name, age) 
        {
            Salary = salary;
            Title = title;
        }
        // Полиморфизм (метод Print)
        public override void Print()
        {
            Console.WriteLine($"{Name} is a {Title}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов и вывод информации
            Man tom = new Man("Tom", 25);
            tom.Print();

            Man bob = new Employee("Bob", 24, 350, "Scientist");
            bob.Print();
        }
    }
}