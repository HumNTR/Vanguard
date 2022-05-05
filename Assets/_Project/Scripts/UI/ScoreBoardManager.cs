using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Vanguard
{
    public class ScoreBoardManager : MonoBehaviour
    {
        public ScoreBoardPlayerReferenceHolder[] ScoreBoardItems = new ScoreBoardPlayerReferenceHolder[10];
        MatchManager mm;
        public void Start()
        {
            mm = FindObjectOfType<MatchManager>();
        }
        public void setScoreBoard()
        {
            for (int i =0; i<10;i++)
            {
                if(mm.Players.ContainsKey(i))
                {
                    Debug.Log("player id = " + i.ToString());
                    ScoreBoardItems[i].Name.text = mm.Players[i].Name;
                    ScoreBoardItems[i].Kills.text = mm.Players[i].Kills.ToString();
                    ScoreBoardItems[i].Deaths.text = mm.Players[i].Deaths.ToString();
                }
                else
                {
                    ScoreBoardItems[i].Name.text = "";
                    ScoreBoardItems[i].Kills.text = "";
                    ScoreBoardItems[i].Deaths.text = "";
                }
            }
        }
    }
}
