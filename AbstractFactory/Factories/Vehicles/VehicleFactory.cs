namespace AbstractFactory.Factories.Vehicles;

public class VehicleFactory : IAbstractFactory<IVehicle> {
    public IVehicle Create(string type) {
        switch (type.ToLower()) {
            case "car":
                return new Car();
            case "truck":
                return new Truck();
            case "train":
                return new Train();
        }
        throw new Exception("Not valid input value");
    }
}