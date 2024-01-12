namespace Decorator;

public class Character {
    protected readonly string _name;
    protected int _attack;
    protected int _defense;

    public Character(string name, int attack, int defense) {
        _name = name;
        _attack = attack;
        _defense = defense;
    }
    
    public virtual string Name => _name;
    public virtual int Attack => _attack;
    public virtual int Defense => _defense;
}