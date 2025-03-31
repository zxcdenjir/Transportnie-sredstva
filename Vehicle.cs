class Vehicle
{
    public string? Model { get; set; }
    public int Speed { get; set; }
    public int MaxSpeed { get; set; }

    public virtual void Move() { }

    public virtual void Stop()
    {
        Speed = 0;
        Console.WriteLine("Остановился транспорт " + Model);
    }

    public Vehicle(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
    }
}

class Car : Vehicle
{
    public int PassengerSeats { get; set; }
    public Car(string model, int maxSpeed, int passengerSeats) : base(model, maxSpeed)
    {
        PassengerSeats = passengerSeats;
    }
    public override void Move()
    {
        Speed = 100;
        Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
    }
    public override void Stop()
    {
        Speed = 0;
        Console.WriteLine("Остановился транспорт " + Model + " со звуком торможения автомобиля");
    }
}

class Truck : Vehicle
{
    public double CargoCapacity { get; set; }
    public Truck(string model, int maxSpeed, double cargoCapacity) : base(model, maxSpeed)
    {
        CargoCapacity = cargoCapacity;
    }
    public override void Move()
    {
        Speed = 70;
        Console.WriteLine($"{Model} движется с грузом со скоростью {Speed} км/ч.");
    }
    public void LoadCargo(double weight)
    {
        if (weight <= CargoCapacity)
        {
            Console.WriteLine($"{Model} загрузил груз весом {weight} тонн.");
        }
        else
        {
            Console.WriteLine($"Невозможно загрузить {weight} тонн на {Model}. Максимальная грузоподъемность: {CargoCapacity} тонн.");
        }
    }
}

class Bicycle : Vehicle
{
    public bool HasBell { get; set; }
    public Bicycle(string model, int maxSpeed, bool hasBell) : base(model, maxSpeed)
    {
        HasBell = hasBell;
    }

    public override void Move()
    {
        Speed = MaxSpeed;
        Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч. (Ограничение скорости велосипеда)");
    }

    public void RingBell()
    {
        if (HasBell)
            Console.WriteLine($"{Model} звонит в звонок");
        else
            Console.WriteLine($"{Model} не оснащен звонком");
    }
}