using UnityEngine;

public class JobButton : MonoBehaviour
{
    public JobUIManager uiManager;

    public enum JobType { Sorceress, Mystic, WarMage, ChaosMage, Elementalist, PyroMancer, IceWitch, 
                            Cleric, Paladin, Crusader, Guardian, Priest, Inquisitor, Saint}
    public JobType selectedJob;

    public void OnClick()
    {
        Job job = selectedJob switch
        {
            JobType.Sorceress => new Sorceress(),
            JobType.Mystic => new Mystic(),
            JobType.WarMage => new WarMage(),
            JobType.ChaosMage => new ChaosMage(),
            JobType.Elementalist => new Elementalist(),
            JobType.PyroMancer => new PyroMancer(),
            JobType.IceWitch => new IceWitch(),

            JobType.Cleric => new Cleric(),
            JobType.Paladin => new Paladin(),
            JobType.Crusader => new Crusader(),
            JobType.Guardian => new Guardian(),
            JobType.Priest => new Priest(),
            JobType.Inquisitor => new Inquisitor(),
            JobType.Saint => new Saint(),

            _ => new Job("Unknown")
        };

        uiManager.ShowJobInfo(job);
    }
}
