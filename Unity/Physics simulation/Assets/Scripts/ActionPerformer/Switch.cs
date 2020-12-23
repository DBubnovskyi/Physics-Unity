using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.ActionPerformer
{
    public enum SwitchAction { Toggle, On, Off, Pulse }
    class Switch : BasePerformer
    {
        public override void PerfomeAction()
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}
