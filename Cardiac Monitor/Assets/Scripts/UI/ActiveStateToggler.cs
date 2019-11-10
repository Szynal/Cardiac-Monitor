using UnityEngine;

namespace Assets.Scripts.UI
{
    public class ActiveStateToggler : MonoBehaviour
    {
        public void ToggleActive()
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}