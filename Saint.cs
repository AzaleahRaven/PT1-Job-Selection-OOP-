public class Saint : Job
{
    public Saint() : base("Saint") { }

    public override string GetAttributes() => "Max Spirit, Max Healing";
    public override string GetBehavior() => "Ultimate healer with revival powers";
    public override string GetUniqueAbility() => "Divine Resurrection: Revives all fallen allies once per battle";
}