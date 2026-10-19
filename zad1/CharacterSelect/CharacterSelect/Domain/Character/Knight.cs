using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Knight : Entity.Character
{
    public Knight(string name) : base(name, CharacterClass.Knight)
    {
        Health = 150;
        Strength = 13;
        Intelligence = 5;
        Agility = 6;
        Defense = 18;
        CriticalChance = 5;
    }

    public override void UseSpecial()
    {
        int damage = Strength * 4;
        Console.WriteLine($"{Name} uses Shield Strike and deals {damage} damage!");
    }
}
