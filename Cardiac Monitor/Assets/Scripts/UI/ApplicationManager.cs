using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class ApplicationManager : MonoBehaviour
    {
        public void Quit()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
        }
    }
}