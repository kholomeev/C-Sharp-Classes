namespace Class
{
    class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Employee : Man
    {
        public decimal Salary { get; set; }
        public string Title { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {}
    }
}