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
        public virtual void PerfomeAction()
        {
            print($"{gameObject.name} action triggered");
        }
    }
}
