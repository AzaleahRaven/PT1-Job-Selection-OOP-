public class Mystic : Job
{
    public Mystic() : base("Mystic") { }

    public override string GetAttributes() => "High Wisdom, Low Defense";
    public override string GetBehavior() => "Manipulates reality and buffs allies";
    public override string GetUniqueAbility() => "Mystic Veil: Temporarily nullifies incoming damage";
}