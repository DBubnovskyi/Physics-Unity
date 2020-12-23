using UnityEngine.SceneManagement;

namespace Assets.Scripts.ActionPerformer
{
    class LoadScene : BasePerformer
    {
        public string SeneName = null;
        public override void PerfomeAction()
        {
            if (!string.IsNullOrWhiteSpace(SeneName))
            {
                SceneManager.LoadScene(SeneName);
            }
        }
    }
}
