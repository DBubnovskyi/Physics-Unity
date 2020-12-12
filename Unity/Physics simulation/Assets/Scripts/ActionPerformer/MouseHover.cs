using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ActionPerformer
{
    public class MouseHover : MonoBehaviour
    {
        public List<GameObject> Hover = null;

        [Tooltip("Represent game objects that should execute actions on mouse click")]
        public List<GameObject> ActionPerformer = null;

        void OnMouseEnter()
        {
            ToggleVisibility();
        }

        void OnMouseExit()
        {
            ToggleVisibility();
        }

        void ToggleVisibility()
        {
            Hover.ForEach(x => x.SetActive(!x.activeSelf));
        }

        void OnMouseDown()
        {
            ActionPerformer.ForEach(x => x.gameObject.GetComponent<BasePerformer>()?.PerfomeAction());
        }
    }
}
