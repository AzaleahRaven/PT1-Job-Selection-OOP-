public class IceWitch : Job
{
    public IceWitch() : base("Ice Witch") { }

    public override string GetAttributes() => "Control-Oriented, Low HP";
    public override string GetBehavior() => "Slows and freezes enemies";
    public override string GetUniqueAbility() => "Glacial Prison: Freezes all enemies briefly";
}