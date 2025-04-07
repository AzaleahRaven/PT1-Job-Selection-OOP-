public class WarMage : Job
{
    public WarMage() : base("WarMage") { }

    public override string GetAttributes() => "Balanced Magic and Strength";
    public override string GetBehavior() => "Combines melee and magic attacks";
    public override string GetUniqueAbility() => "Bladefire: Enchants sword with flame to deal bonus damage";
}