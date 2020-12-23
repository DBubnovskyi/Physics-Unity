using System;
using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts.ActionPerformer
{
    class ToggleVisibility : BasePerformer
    {
        public SwitchAction Action = SwitchAction.Toggle;
        public List<GameObject> Elements = null;
        public override void PerfomeAction()
        {
            switch (Action)
            {
                case SwitchAction.Toggle:
                    Elements.ForEach(x => x.SetActive(!x.activeSelf));
                    break;
                case SwitchAction.On:
                    Elements.ForEach(x => x.SetActive(true));
                    break;
                case SwitchAction.Off:
                    Elements.ForEach(x => x.SetActive(false));
                    break;
                default:
                    break;
            }
        }
    }
}
