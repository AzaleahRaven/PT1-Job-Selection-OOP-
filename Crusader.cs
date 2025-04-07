public class Crusader : Job
{
    public Crusader() : base("Crusader") { }

    public override string GetAttributes() => "Balanced Attack and Defense";
    public override string GetBehavior() => "Frontline holy warrior";
    public override string GetUniqueAbility() => "Divine Charge: Dashes through enemies, dealing damage";
}