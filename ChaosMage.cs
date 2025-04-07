public class ChaosMage : Job
{
    public ChaosMage() : base("Chaos Mage") { }

    public override string GetAttributes() => "Unstable Power, Randomized Damage";
    public override string GetBehavior() => "Unleashes unpredictable spells";
    public override string GetUniqueAbility() => "Entropy Storm: Casts a storm with random effects";
}