public class Priest : Job
{
    public Priest() : base("Priest") { }

    public override string GetAttributes() => "High Healing, Fragile";
    public override string GetBehavior() => "Support role with strong healing abilities";
    public override string GetUniqueAbility() => "Blessing of Light: Boosts healing for a short time";
}