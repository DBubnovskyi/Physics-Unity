using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.ActionPerformer
{
    class BasePerformer : MonoBehaviour
    {
        virtual public void PerfomeAction()
        {
            print($"{gameObject.name} action triggered");
        }
    }
}
