#region Header
// Copyright Koninklijke Philips N.V. 2023
#endregion

namespace AbstractFactory.Factories.Animals;

public interface IAnimal {
    void GetType();
    void MakeSound();
}