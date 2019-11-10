using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    [RequireComponent(typeof(Image))]
    public class ScrollDetailTexture : MonoBehaviour
    {
        public bool UniqueMaterial = false;
        public Vector2 ScrollPerSecond = Vector2.zero;

        private Matrix4x4 matrix;
        private Material copy;
        private Material original;
        private Image sprite;
        private Material material;

        private void OnEnable()
        {
            sprite = GetComponent<Image>();
            original = sprite.material;

            if (!UniqueMaterial || sprite.material == null)
            {
                return;
            }

            copy = new Material(original) {name = "Copy of " + original.name, hideFlags = HideFlags.DontSave};
            sprite.material = copy;
        }

        private void OnDisable()
        {
            if (copy != null)
            {
                sprite.material = original;
                if (Application.isEditor)
                {
                    DestroyImmediate(copy);
                }
                else
                {
                    Destroy(copy);
                }

                copy = null;
            }

            original = null;
        }

        private void Update()
        {
            Material mat = copy != null ? copy : original;

            if (mat == null)
            {
                return;
            }

            Texture tex = mat.GetTexture("_DetailTex");

            if (tex != null)
            {
                mat.SetTextureOffset("_DetailTex", ScrollPerSecond * Time.time);
            }
        }
    }
}