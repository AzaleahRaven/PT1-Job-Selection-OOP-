public class Elementalist : Job
{
    public Elementalist() : base("Elementalist") { }

    public override string GetAttributes() => "Versatile Elements, Low Durability";
    public override string GetBehavior() => "Commands fire, ice, lightning, and earth";
    public override string GetUniqueAbility() => "Elemental Surge: Cycle through elemental boosts";
}