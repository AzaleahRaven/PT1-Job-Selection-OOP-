public class Inquisitor : Job
{
    public Inquisitor() : base("Inquisitor") { }

    public override string GetAttributes() => "High Crit Chance, Moderate HP";
    public override string GetBehavior() => "Purges evil with swift retribution";
    public override string GetUniqueAbility() => "Purge Flame: Deals extra damage to cursed or undead enemies";
}