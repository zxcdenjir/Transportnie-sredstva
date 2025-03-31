class Program
{
    static void Main()
    {
        Car car = new Car("BMW", 240, 5);
        Truck truck = new Truck("Volvo", 160, 18.0);
        Bicycle bicycle = new Bicycle("Forward", 30, true);

        Console.WriteLine("Автомобиль:");
        car.Move();
        car.Stop();
        Console.WriteLine();

        Console.WriteLine("Грузовик:");
        truck.Move();
        truck.LoadCargo(15.0);
        truck.LoadCargo(20.0);
        truck.Stop();
        Console.WriteLine();

        Console.WriteLine("Велосипед:");
        bicycle.Move();
        bicycle.RingBell();
        bicycle.Stop();
    }
}