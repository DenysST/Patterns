namespace AbstractFactory.Factories.Animals;

public class Dog : IAnimal {
    public new void GetType() {
        Console.WriteLine("Dog");
    }

    public void MakeSound() {
        Console.WriteLine("Bark");
    }
}