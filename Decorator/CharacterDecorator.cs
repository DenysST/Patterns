namespace Decorator;

public abstract class CharacterDecorator : Character {
    private readonly Character _character;

    protected CharacterDecorator(Character character ,string name, int attack, int defense) : base(name, attack, defense) {
        _character = character;
    }

    public override string Name => $"{_character.Name}, {_name}";
    public override int Attack => _character.Attack + _attack;
    public override int Defense => _character.Defense + _defense;
}