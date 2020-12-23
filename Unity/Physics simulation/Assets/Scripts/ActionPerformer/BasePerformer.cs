using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.ActionPerformer
{
    public class BasePerformer : MonoBehaviour
    {
        public delegate void EventHandler();
        public virtual event EventHandler ActionStarted = delegate { };
        public virtual event EventHandler ActionEnded = delegate { };
        public virtual void PerfomeAction()
        {
            ActionStarted();
            print($"{gameObject.name} action triggered");
            ActionEnded();
        }
    }
}
