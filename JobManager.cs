using UnityEngine;
using System.Collections.Generic;

public class JobManager : MonoBehaviour
{
    List<Job> allJobs = new List<Job>();

    void Start()
    {
        allJobs.Add(new Sorceress());
        allJobs.Add(new Mystic());
        allJobs.Add(new WarMage());
        allJobs.Add(new ChaosMage());
        allJobs.Add(new Elementalist());
        allJobs.Add(new PyroMancer());
        allJobs.Add(new IceWitch());

        allJobs.Add(new Cleric());
        allJobs.Add(new Paladin());
        allJobs.Add(new Crusader());
        allJobs.Add(new Guardian());
        allJobs.Add(new Priest());
        allJobs.Add(new Inquisitor());
        allJobs.Add(new Saint());


        foreach (Job job in allJobs)
        {
            job.UseAbility();
        }
    }
}
