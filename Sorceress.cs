public class Sorceress : Job
{
    public Sorceress() : base("Sorceress") { }

    public override string GetAttributes() => "High Mana, Medium Health";
    public override string GetBehavior() => "Casts elemental spells at range";
    public override string GetUniqueAbility() => "Arcane Burst: Deals massive magic damage in a small area";
}