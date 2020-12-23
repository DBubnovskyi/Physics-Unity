using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts.ActionPerformer
{
    public class MoveCamera : BasePerformer
    {
        public Camera Camera = null;
        public float Speed = 1.0f;
        public float Smooth = 1.0f;
        public float StopDistance = 0.1f;
        public List<GameObject> Trget = null;
        private bool _startMove = false;
        private int _index = 0;
        private GameObject _target;

        public override event EventHandler ActionStarted = delegate { };
        public override event EventHandler ActionEnded = delegate { };

        private void Start()
        {
            if(Camera != null)
            {
                _target = Camera.gameObject;
            }
            else
            {
                _target = gameObject;
            }
        }
        // Update is called once per frame
        void Update()
        {
            if (_startMove && Trget != null)
            {
                _target.transform.position = Vector3.Lerp(_target.transform.position, Trget[_index].transform.position, Time.deltaTime * Speed);

                Quaternion target = Quaternion.Euler(Trget[_index].transform.eulerAngles.x, Trget[_index].transform.eulerAngles.y, Trget[_index].transform.eulerAngles.z);
                _target.transform.rotation = Quaternion.Slerp(_target.transform.rotation, target, Time.deltaTime * Smooth);

                float dist = Vector3.Distance(Trget[_index].transform.position, _target.transform.position);
                if (dist < StopDistance)
                {
                    //print($"rotate is equall  {Trget[_index].transform.position} - {transform.position}");
                    ++_index;
                    if(_index == (Trget.Count))
                    {
                        //print($"Move stop");
                        _startMove = false;
                        _index = 0;
                        ActionEnded();
                    }
                }
            }
        }

        public override void PerfomeAction()
        {
            ActionStarted();
            _startMove = true;
        }
    }
}