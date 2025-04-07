public class PyroMancer : Job
{
    public PyroMancer() : base("Pyromancer") { }

    public override string GetAttributes() => "High Fire Power, Glass Cannon";
    public override string GetBehavior() => "Deals AoE fire damage";
    public override string GetUniqueAbility() => "Inferno: Sets the battlefield ablaze";
}