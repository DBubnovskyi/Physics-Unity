using UnityEngine;

namespace Assets.Scripts.Editor
{
    public class HideOnPlay : MonoBehaviour
    {
        public void Start()
        {
            gameObject.SetActive(false);
        }
    }
}
