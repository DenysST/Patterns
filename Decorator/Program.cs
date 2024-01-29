// See https://aka.ms/new-console-template for more information

using Decorator;

internal class Program {
    public static void Main(string[] args) {
        Character dwarf = new Character("Dwarf", 20, 30);
        dwarf = new CharacterAttackDecorator(dwarf, "sword", 15);
        dwarf = new CharacterDefenseDecorator(dwarf, "shield", 20);
        Console.WriteLine($"Final stats: {dwarf.Attack} / {dwarf.Defense}");
    }
}