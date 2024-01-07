namespace AbstractFactory.Factories.Vehicles;

public class Train : IVehicle {
    public new void GetType() {
        Console.WriteLine("Speed train");
    }

    public void GetColour() {
        Console.WriteLine("Black");
    }
}