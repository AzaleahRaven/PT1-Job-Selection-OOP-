using UnityEngine;

public class PlayerJob
{
    public virtual string GetAttributes() => "None";
    public virtual string GetBehavior() => "Basic";
    public virtual string GetUniqueAbility() => "No ability";

    public string jobName;

    public PlayerJob(string name)
    {
        jobName = name;
    }

    public virtual void UseAbility()
    {
        Debug.Log($"{jobName} uses a basic skill.");
    }
}
