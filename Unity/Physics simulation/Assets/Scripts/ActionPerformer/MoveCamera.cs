using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ActionPerformer
{
    public class MoveCamera : BasePerformer
    {

        public float Speed = 1.0f;
        public float Smooth = 1.0f;
        public float StopDistance = 0.1f;
        public List<GameObject> Trget = null;
        private bool _StartMove = false;
        private int _index = 0;


        // Update is called once per frame
        void Update()
        {
            if (_StartMove && Trget != null)
            {
                transform.position = Vector3.Lerp(transform.position, Trget[_index].transform.position, Time.deltaTime * Speed);

                Quaternion target = Quaternion.Euler(Trget[_index].transform.eulerAngles.x, Trget[_index].transform.eulerAngles.y, Trget[_index].transform.eulerAngles.z);
                transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * Smooth);

                float dist = Vector3.Distance(Trget[_index].transform.position, transform.position);
                if (dist < StopDistance)
                {
                    print($"rotate is equall  {Trget[_index].transform.position} - {transform.position}");
                    ++_index;
                    if(_index == (Trget.Count))
                    {
                        print($"Move stop");
                        _StartMove = false;
                        _index = 0;
                    }
                }
            }
        }

        public override void PerfomeAction()
        {
            _StartMove = true;
        }
    }
}