public class Paladin : Job
{
    public Paladin() : base("Paladin") { }

    public override string GetAttributes() => "High Defense, Holy Strength";
    public override string GetBehavior() => "Defends allies and smites foes";
    public override string GetUniqueAbility() => "Holy Judgment: Deals damage based on defense stat";
}