using System;
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
        private bool _inProgress = false;
        private int _actionFineshed = 0;

        private void Start()
        {
            foreach (var element in ActionPerformer)
            {
                var performer = element.gameObject.GetComponent<BasePerformer>();
                if(performer != null)
                    performer.ActionEnded += IsActionsEnded;
            }
        }

        private void IsActionsEnded()
        {
            print($"IsActionsEnded");
            _actionFineshed++;
            if (ActionPerformer.Count >= _actionFineshed)
            {
                _inProgress = false;
                _actionFineshed = 0;
            }
        }

        void OnMouseEnter()
        {
            if (!_inProgress)
                Hover.ForEach(x => x.gameObject.GetComponent<BasePerformer>()?.PerfomeAction());
        }

        void OnMouseExit()
        {
            if(!_inProgress)
                Hover.ForEach(x => x.gameObject.GetComponent<BasePerformer>()?.PerfomeAction());
        }

        void OnMouseDown()
        {
            _inProgress = true;
            ActionPerformer.ForEach(x => x.gameObject.GetComponent<BasePerformer>()?.PerfomeAction());
        }
    }
}
