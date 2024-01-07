#region Header
// Copyright Koninklijke Philips N.V. 2023
#endregion

namespace AbstractFactory.Factories.Animals;

public class Cat : IAnimal {
    public new void GetType() {
        Console.WriteLine("Cat");
    }

    public void MakeSound() {
        Console.WriteLine("Meow");
    }
}