namespace AbstractClasses
{
    abstract class Transport
    {
        public void Move()
        {
            Console.WriteLine("Транспортное средство движется!");
        }
    }

    class Car : Transport
    {
        
    }

    class Aircraft : Transport
    {
        
    }
    class Ship : Transport
    {
        
    }
    static class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Car();
            Transport plane = new Aircraft();
            Transport ship = new Ship();

            car.Move();
            plane.Move();
            ship.Move();
        }
    }
}