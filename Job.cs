using UnityEngine;
public class Job
{
    public string jobName;

    public Job(string name)
    {
        jobName = name;
    }

    public virtual string GetAttributes() => "General attributes";
    public virtual string GetBehavior() => "Standard behavior";
    public virtual string GetUniqueAbility() => "No special ability";

    public virtual void UseAbility()
    {
        Debug.Log($"{jobName} uses a basic skill.");
    }
}