using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JobUIManager : MonoBehaviour
{
    public TextMeshProUGUI jobNameText;
    public TextMeshProUGUI attributesText;
    public TextMeshProUGUI behaviorText;
    public TextMeshProUGUI abilityText;

    public GameObject infoPanel;

    public void ShowJobInfo(Job job)
    {
        jobNameText.text = job.jobName;
        attributesText.text = job.GetAttributes();
        behaviorText.text = job.GetBehavior();
        abilityText.text = job.GetUniqueAbility();

        infoPanel.SetActive(true);
    }

    public void HideJobInfo()
    {
        infoPanel.SetActive(false);
    }
}
