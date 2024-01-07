namespace AbstractFactory.Factories.Vehicles;

public class Truck : IVehicle {
    public new void GetType() {
        Console.WriteLine("Heavy truck");
    }

    public void GetColour() {
        Console.WriteLine("White");
    }
}