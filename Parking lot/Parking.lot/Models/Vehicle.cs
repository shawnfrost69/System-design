namespace DefaultNamespace;

public abstract class Vehicle
{
    public string LicensePlate { get; set; }
    public VehicleType Type{ get; set; }
    
    public Vehicle(string plate, VehicleType type)
    {
        LicensePlate = plate;
        Type = type;
    }
}

public class Car : Vehicle
{
    public Car(string plate) : base(plate, VehicleType.Car) {}
}

public class Bike : Vehicle
{
    public Bike(string plate) : base(plate, VehicleType.Bike) {}
}

public class Bus : Vehicle
{
    public Bus(string plate) : base(plate, VehicleType.Bus){}
}






