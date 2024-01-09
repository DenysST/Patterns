using Newtonsoft.Json;

namespace Prototype;

public class Warrior : IPrototype<Warrior> {
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Warrior(string name, int health, int attackPower) {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }


    public Warrior Clone() {
        return new Warrior(Name, Health, AttackPower);
    }
    
    public override string ToString() {
        return JsonConvert.SerializeObject(this);
    }
}