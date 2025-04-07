public class Guardian : Job
{
    public Guardian() : base("Guardian") { }

    public override string GetAttributes() => "Tanky, Low Offense";
    public override string GetBehavior() => "Absorbs damage and protects allies";
    public override string GetUniqueAbility() => "Iron Will: Becomes immune to knockback and crowd control";
}