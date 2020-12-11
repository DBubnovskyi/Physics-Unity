using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.ActionPerformer
{
    class Switch : BasePerformer
    {
        public override void PerfomeAction()
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}
