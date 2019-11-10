using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class DropMe : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
    {
        public Image ContainerImage;
        public Image ReceivingImage;
        public Color HighlightColor = Color.yellow;

        private Color normalColor;

        public void OnEnable()
        {
            if (ContainerImage != null)
                normalColor = ContainerImage.color;
        }

        public void OnDrop(PointerEventData data)
        {
            ContainerImage.color = normalColor;

            if (ReceivingImage == null)
            {
                return;
            }

            Sprite dropSprite = GetDropSprite(data);

            if (dropSprite != null)
            {
                ReceivingImage.overrideSprite = dropSprite;
            }
        }

        public void OnPointerEnter(PointerEventData data)
        {
            if (ContainerImage == null)
            {
                return;
            }

            Sprite dropSprite = GetDropSprite(data);

            if (dropSprite != null)
            {
                ContainerImage.color = HighlightColor;
            }
        }

        public void OnPointerExit(PointerEventData data)
        {
            if (ContainerImage == null)
            {
                return;
            }

            ContainerImage.color = normalColor;
        }

        private static Sprite GetDropSprite(PointerEventData data)
        {
            var originalObj = data.pointerDrag;
            if (originalObj == null)
            {
                return null;
            }

            var dragMe = originalObj.GetComponent<DragMe>();
            if (dragMe == null)
            {
                return null;
            }

            var srcImage = originalObj.GetComponent<Image>();
            return srcImage == null ? null : srcImage.sprite;
        }
    }
}