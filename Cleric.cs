public class Cleric : Job
{
    public Cleric() : base("Cleric") { }

    public override string GetAttributes() => "High Spirit, Medium Defense";
    public override string GetBehavior() => "Heals allies and provides buffs";
    public override string GetUniqueAbility() => "Sanctuary: Heals nearby allies over time";
}