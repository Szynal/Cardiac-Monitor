using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.UI
{
    public class ResizePanel : MonoBehaviour, IPointerDownHandler, IDragHandler
    {
        public Vector2 MinSize = new Vector2(100, 100);
        public Vector2 MaxSize = new Vector2(400, 400);

        private RectTransform panelRectTransform;
        private Vector2 originalLocalPointerPosition;
        private Vector2 originalSizeDelta;

        private void Awake()
        {
            panelRectTransform = transform.parent.GetComponent<RectTransform>();
        }

        public void OnPointerDown(PointerEventData data)
        {
            originalSizeDelta = panelRectTransform.sizeDelta;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(panelRectTransform, data.position,
                data.pressEventCamera, out originalLocalPointerPosition);
        }

        public void OnDrag(PointerEventData data)
        {
            if (panelRectTransform == null)
                return;

            RectTransformUtility.ScreenPointToLocalPointInRectangle(panelRectTransform, data.position,
                data.pressEventCamera, out var localPointerPosition);
            Vector3 offsetToOriginal = localPointerPosition - originalLocalPointerPosition;

            Vector2 sizeDelta = originalSizeDelta + new Vector2(offsetToOriginal.x, -offsetToOriginal.y);
            sizeDelta = new Vector2(
                Mathf.Clamp(sizeDelta.x, MinSize.x, MaxSize.x),
                Mathf.Clamp(sizeDelta.y, MinSize.y, MaxSize.y)
            );

            panelRectTransform.sizeDelta = sizeDelta;
        }
    }
}