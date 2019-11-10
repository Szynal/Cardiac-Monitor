using UnityEngine;

namespace Assets.Scripts.UI
{
    public class TiltWindow : MonoBehaviour
    {
        public Vector2 Range = new Vector2(5f, 3f);

        private Transform trans;
        private Quaternion start;
        private Vector2 rot = Vector2.zero;

        private void Start()
        {
            trans = transform;
            start = trans.localRotation;
        }

        private void Update()
        {
            Vector3 pos = Input.mousePosition;

            float halfWidth = Screen.width * 0.5f;
            float halfHeight = Screen.height * 0.5f;
            float x = Mathf.Clamp((pos.x - halfWidth) / halfWidth, -1f, 1f);
            float y = Mathf.Clamp((pos.y - halfHeight) / halfHeight, -1f, 1f);
            rot = Vector2.Lerp(rot, new Vector2(x, y), Time.deltaTime * 5f);
            trans.localRotation = start * Quaternion.Euler(-rot.y * Range.y, rot.x * Range.x, 0f);
        }
    }
}