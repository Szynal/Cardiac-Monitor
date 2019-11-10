using UnityEngine;

namespace Assets.Scripts.HyperLink
{
    public class HyperLinks : MonoBehaviour
    {
        public void OpenURL()
        {
            Application.OpenURL("https://github.com/Szynal/Space-Oddity");
        }
    }
}