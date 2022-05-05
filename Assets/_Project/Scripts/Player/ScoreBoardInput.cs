using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using FishNet.Object;
using UnityEngine.UI;
namespace Vanguard {
    public class ScoreBoardInput : NetworkBehaviour
    {
        public RectMask2D mask;
        public override void OnStartClient()
        {
            if (!IsOwner)
            {
                enabled = false;
            }
            else
            {
                InputManager.OnScoreBoardDown += ScoreBoardDown;
                InputManager.OnScoreBoardUp += ScoreBoardUp;
            }
            base.OnStartClient();
        }
        private void ScoreBoardUp()
        {
            mask.enabled = true;
        }
        private void ScoreBoardDown()
        {
            mask.enabled = false;
        }
    }
}