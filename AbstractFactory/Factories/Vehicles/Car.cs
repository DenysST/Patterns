namespace AbstractFactory.Factories.Vehicles;

public class Car : IVehicle {
    public new void GetType() {
        Console.WriteLine("Toyota");
    }

    public void GetColour() {
        Console.WriteLine("Red");
    }
}