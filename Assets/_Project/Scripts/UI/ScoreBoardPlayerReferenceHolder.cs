using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBoardPlayerReferenceHolder : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Name, Kills, Deaths;
    public void activateTexts()
    {
        Name.enabled = true;
        Kills.enabled = true;
        Deaths.enabled = true;
    }
    public void disableTexts()
    {
        Name.enabled = false;
        Kills.enabled = false;
        Deaths.enabled = false;
    }
}
